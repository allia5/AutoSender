using AutoSender.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Services.Foundation.CompanyService
{
    public partial class CompanyService
    {
        public delegate ValueTask<CompanyToAddResult> AddCompanyToAddResultDelegate();

        public async void TryCatch(AddCompanyToAddResultDelegate AddCompanyToAddResultDelegate)
        {

        }
    }
}
