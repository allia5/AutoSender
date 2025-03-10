using AutoSender.Dto;
using AutoSender.Models.Companys.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Services.Foundation.CompanyService
{
    public partial class CompanyFoundationService
    {
        public delegate ValueTask<CompanyToAddResult> AddCompanyToAddResultDelegate();

        public async ValueTask<CompanyToAddResult> TryCatch(AddCompanyToAddResultDelegate AddCompanyToAddResultDelegate)
        {
            try
            {
                return await AddCompanyToAddResultDelegate();
            }
            catch (NullCompanyException nullCompanyException)
            {
                return new CompanyToAddResult { Status = statusAddCompany.NotAdd };
            }
            catch (InvalidCompanyException invalidCompanyException)
            {
                return new CompanyToAddResult { Status = statusAddCompany.NotAdd };
            }
        }
    }
}
