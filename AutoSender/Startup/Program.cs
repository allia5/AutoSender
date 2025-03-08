// See https://aka.ms/new-console-template for more information
using AutoSender.Brokers.StorageBroker;
using AutoSender.Services.Foundation.ClientService;
using AutoSender.Services.Foundation.CompanyService;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace AutoSender.Startup
{
    public partial class Program
    {
        public readonly ICompanyService _CompanyService;
   
        public Program(ICompanyService companyService)
        {
            this._CompanyService = companyService;
        }


        public static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IStorageBroker, StorageBroker>();
            serviceCollection.AddScoped<IClientService, ClientService>();
            serviceCollection.AddScoped<ICompanyService, CompanyService>();
            serviceCollection.AddScoped<Program>();
            var program = serviceCollection.BuildServiceProvider().GetRequiredService<Program>();
         
            await program.StartProgram();
            


            Console.WriteLine("Hello, World!");
        }
    }
}









