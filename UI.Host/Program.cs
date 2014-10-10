using System;
using Microsoft.Owin.Hosting;
using NLog;
using NLog.Interface;

namespace UI.Host
{
    internal class Program
    {
        private static readonly ILogger _logger = new LoggerAdapter(LogManager.GetCurrentClassLogger());
        static readonly IConfigurationManager ConfigurationManager = new ConfigurationManagerWrapper();
        private static void Main(string[] args)
        {
            var baseAddress = ConfigurationManager.GetSetting("OwinEndPoint");

            using (WebApp.Start<Startup>(baseAddress))
            {
                _logger.Info("Dashboard WebServer running. Press <enter> key to exit");
                Console.ReadLine();
            }
        }


    }
}