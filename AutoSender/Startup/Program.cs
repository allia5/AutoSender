// See https://aka.ms/new-console-template for more information
using AutoSender.Brokers.StorageBroker;
using AutoSender.Services.Foundation.ClientService;
using AutoSender.Services.Foundation.CompanyService;
using AutoSender.Services.Orchestration.ClientOrchestrationService;
using AutoSender.Services.processing.ClientOrchestrationService;
using AutoSender.Services.Processing.ClientProcessingService;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace AutoSender.Startup
{
    public partial class Program
    {
        public readonly ICompanyFoundationService _CompanyService;
   
        public Program(ICompanyFoundationService companyService)
        {
            this._CompanyService = companyService;
        }


        public static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IStorageBroker, StorageBroker>();
            serviceCollection.AddScoped<IClientFoundationService, ClientFoundationService>();
            serviceCollection.AddScoped<ICompanyFoundationService, CompanyFoundationService>();
            serviceCollection.AddScoped<IClientProcessingService,ClientProcessingService>();
            serviceCollection.AddScoped<IClientOrchestrationService, ClientOrchestrationService>();
            serviceCollection.AddScoped<Program>();
            var program = serviceCollection.BuildServiceProvider().GetRequiredService<Program>();
         
            await program.StartProgram();
            


            Console.WriteLine("Hello, World!");
        }
    }
}









