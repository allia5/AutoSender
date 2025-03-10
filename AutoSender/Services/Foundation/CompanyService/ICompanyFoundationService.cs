using AutoSender.Dto;
using AutoSender.Models.Companys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Services.Foundation.CompanyService
{
    public interface ICompanyFoundationService
    {
        public ValueTask<IQueryable<Company>> RetrieveAllCompanyAsync();
        public ValueTask<CompanyToAddResult> AddCompany(CompanyToAdd company);
    }
}
