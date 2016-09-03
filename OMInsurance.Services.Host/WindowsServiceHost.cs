using OMInsurance.Configuration;
using OMInsurance.Log;
using System;
using System.ServiceModel;
using System.ServiceProcess;

namespace OMInsurance.Services.Host
{
	public sealed class WindowsServiceHost : ServiceBase
	{
        private WcfServiceHost _host;
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				StopService();
			}

			base.Dispose(disposing);
		}

		public WindowsServiceHost()
		{
			ServiceName = AppConfigurationHelper.GetConfiguration("ServiceContractName");
		}

		internal void Start(string[] args)
		{
			OnStart(args);
		}

		protected override void OnStart(string[] args)
		{
            FileLog.Initialize(ServiceName);
            string serviceAssembly = AppConfigurationHelper.GetConfiguration("ServiceAssembly");
            string serviceType = AppConfigurationHelper.GetConfiguration("ServiceType");
            string InterfaceAssembly = AppConfigurationHelper.GetConfiguration("InterfaceAssembly");
            string InterfaceType = AppConfigurationHelper.GetConfiguration("InterfaceType");
            string baseUri = AppConfigurationHelper.GetConfiguration("BaseUri");
            string mexUri = AppConfigurationHelper.GetConfiguration("MexUri");
            _host = CreateServiceHost(
                serviceAssembly, 
                serviceType, 
                InterfaceAssembly, 
                InterfaceType, 
                baseUri,
                mexUri);
			try
			{
				_host.Open();
			}
			catch (Exception e)
			{
				string message = string.Format("Error starting service {0}", ServiceName);
				FileLog.Fatal(message, e);
				throw;
			}

            FileLog.Info(string.Format("Service {0} started. Address: {1}.", ServiceName, baseUri));
		}

        private WcfServiceHost CreateServiceHost(string serviceAssembly, string ServiceType,
            string InterfaceAssembly, string InterfaceType, string Url, string mexhttpURL)
		{
			TypeLoader serviceTypeLoader = new TypeLoader(serviceAssembly);
            Type serviceType = serviceTypeLoader.GetTypeByName(ServiceType);

			if (serviceType == null)
			{
				string msg = string.Format("Service {0} initialization failed. Unable to instantiate service type {1} from assembly {2}.",
                    ServiceName, ServiceType, serviceAssembly);
				FileLog.Error(msg);
                throw new ApplicationException(msg);
			}

			TypeLoader interfaceTypeLoader = new TypeLoader(InterfaceAssembly);
			Type interfaceType = interfaceTypeLoader.GetTypeByName(InterfaceType);
			if (interfaceType == null)
			{
				string msg = string.Format("Service {0} initialization. Type {1} is not found in the assembly {2}.",
					ServiceName, InterfaceType, InterfaceAssembly);
                FileLog.Error(msg);
                throw new ApplicationException(msg);
			}

			WcfServiceHost host = new WcfServiceHost(interfaceType, serviceType, new Uri(mexhttpURL), new Uri(Url));

			return host;
		}

		protected override void OnStop()
		{
			StopService();
			FileLog.Info("Service stopped.");
		}

		private void StopService()
		{
			if (_host != null)
			{
				if (_host.State == CommunicationState.Faulted)
				{
					_host.Abort();
				}
				_host.Close();
				_host = null;
			}
		}
	}
}