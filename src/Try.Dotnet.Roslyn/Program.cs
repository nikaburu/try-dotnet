using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Try.Dotnet.Roslyn
{
    class Program
    {
        static void Main(string[] args)
        {
            #region settings
            
            string contractPath = "sources\\IPropertyServices.cs";
            string servicePath = "sources\\PropertyServices.cs";

            #endregion

            ILoggerFactory loggerFactory = new LoggerFactory().AddConsole();
            ILogger logger = loggerFactory.CreateLogger<Program>();

            string contract = File.ReadAllText(contractPath);
            logger.LogInformation(contract);

            string service = File.ReadAllText(servicePath);
            logger.LogInformation(service);

            (contract, service) = Roslyn.Refactor(contract, service);

            File.WriteAllText(contractPath, contract);
            File.WriteAllText(servicePath, service);
        }
    }

    class Roslyn
    {
        public static (string contract, string service) Refactor(string contract, string service)
        {
            //todo
            //return (interfaceRoot.ToFullString(), root.NormalizeWhitespace().ToFullString());
            return (contract, service);
        }
    }
}
