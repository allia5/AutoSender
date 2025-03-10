using AutoSender.Dto;
using AutoSender.Models.Companys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Services.Foundation.Mapper
{
    public static class Mapper
    {
        public static Company MapperToCompany(CompanyToAdd companyToAdd, int id)
        {
            return new Company
            {
                CompanyEmail = companyToAdd.Email,
                CompanyName = companyToAdd.JobName,
                Id = id + 1,
                JobTitle = "",
                Occurs = 0,
                StatusCompany = StatusCompany.NotSent
            };
        }
    }
}
