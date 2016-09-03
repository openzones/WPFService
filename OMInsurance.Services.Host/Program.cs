using System;
using System.ServiceProcess;

namespace OMInsurance.Services.Host
{
	static class Program
	{
		static void Main(string[] args)
		{
			if (args != null && args.Length > 0 && args[0].Equals("/console", StringComparison.OrdinalIgnoreCase))
			{
				RunAsConsole(args);
				return;
			}

			WindowsServiceHost service = new WindowsServiceHost();
			ServiceBase.Run(service);
		}

		static void RunAsConsole(string[] args)
		{
			Console.WriteLine("Service starting...");

			using (WindowsServiceHost host = new WindowsServiceHost())
			{
				host.Start(args);

				Console.WriteLine("Hit ENTER to exit.");
				Console.ReadLine();
			}
		}
	}
}