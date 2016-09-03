using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Xml;

namespace OMInsurance.Services.Host
{
	public class WcfServiceHost : ServiceHost
	{
        public WcfServiceHost(Type implementedContract, Type serviceType, Uri mexHttpAddress, params Uri[] baseAddresses)
			: base(serviceType, baseAddresses)
		{
            Uri baseAddress = baseAddresses[0];
            Binding binding = AddEndpoint(implementedContract, serviceType, baseAddress);
			SetBehaviors(binding);

            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            behavior.HttpGetUrl = mexHttpAddress;
            behavior.HttpGetEnabled = true;
            Description.Behaviors.Add(behavior);
            AddServiceEndpoint(
                typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexTcpBinding(),
                "mex"
             );

			Description.Behaviors.Add(new ServiceThrottlingBehavior
			{
				MaxConcurrentCalls = 100000,
				MaxConcurrentInstances = 100000,
				MaxConcurrentSessions = 100000
			});
		}

		private Binding AddEndpoint(Type implementedContract, Type serviceType, Uri baseAddress)
		{
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
			binding.MaxBufferSize = int.MaxValue;
			binding.MaxReceivedMessageSize = int.MaxValue;
            binding.MaxBufferPoolSize = int.MaxValue;
			binding.ReaderQuotas = XmlDictionaryReaderQuotas.Max;
            AddServiceEndpoint(implementedContract, binding, baseAddress);

			return binding;
		}

		private void SetBehaviors(Binding binding)
		{
			ServiceBehaviorAttribute behaviorAttribute = Description.Behaviors.Find<ServiceBehaviorAttribute>();
			if (behaviorAttribute == null)
			{
				behaviorAttribute = new ServiceBehaviorAttribute();
				Description.Behaviors.Add(behaviorAttribute);
			}
			behaviorAttribute.ConcurrencyMode = ConcurrencyMode.Multiple;
			behaviorAttribute.IncludeExceptionDetailInFaults = true;
		}
	}
}