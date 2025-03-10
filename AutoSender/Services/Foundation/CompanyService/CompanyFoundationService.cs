using AutoSender.Brokers.StorageBroker;
using AutoSender.Dto;
using AutoSender.Models.Companys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoSender.Services.Foundation.Mapper.Mapper;
namespace AutoSender.Services.Foundation.CompanyService
{
    public partial class CompanyFoundationService : ICompanyFoundationService
    {
        public readonly IStorageBroker storageBroker;
        public CompanyFoundationService( IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<CompanyToAddResult> AddCompany(CompanyToAdd company)
        {

            var AllCompany = await this.storageBroker.SelectAllCompany();
            var AllCompanyList = AllCompany.ToList();

            var Company = MapperToCompany(company, AllCompanyList.Count());
            var DataOnAdd = await this.storageBroker.InsertCompany(Company);
            if (DataOnAdd != null)
            {
                return new CompanyToAddResult
                {
                    Email = DataOnAdd.CompanyEmail,
                    Status = statusAddCompany.Add
                };

            }
            else
            {
                return new CompanyToAddResult
                {
                    Email = company.Email,
                    Status = statusAddCompany.NotAdd
                };
            }
        }

        public async ValueTask<IQueryable<Company>> RetrieveAllCompanyAsync()
        {
            return await this.storageBroker.SelectAllCompany();
        }
    }
}
