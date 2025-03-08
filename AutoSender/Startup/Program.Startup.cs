using AutoSender.Dto;
using AutoSender.Models.Clients;
using AutoSender.Models.Companys;
using AutoSender.Services.Foundation.ClientService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Startup
{
    public  partial class Program
    {

        public async ValueTask<IQueryable<Company>> GetAllCompany()
        {
            
            return await _CompanyService.RetrieveAllCompanyAsync();

        }

        public async  Task  StartProgram()
        {
            Console.WriteLine("Starting program... WHAT you want : 1- Get All Company Account 2-Post Account to Database 3-Send Smtp Automaticly");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Getting all Company account...");
                    var Companys = await GetAllCompany();
                    foreach (var company in Companys)
                    {
                        Console.WriteLine($"company Name :{company.CompanyName} \n Company Email :{company.CompanyEmail}  \n      job Title:     {company.JobTitle}   \n      ");
                    }
                    break;
                case 2:
                    Console.WriteLine("Posting Company to database...");
                    var CompanyToAdd = new CompanyToAdd();
                    Console.WriteLine("Email : \n"); CompanyToAdd.Email= Console.ReadLine();
                    Console.WriteLine("Company Name : \n"); CompanyToAdd.CompanyName = Console.ReadLine(); Console.WriteLine("wait... : \n");
                   var result = await this._CompanyService.AddCompany(CompanyToAdd);
                    Console.WriteLine($"ddata on {result.Status.ToString()}");
                    break;
                case 3:
                    Console.WriteLine("Sending smtp automaticly...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
    }
}
