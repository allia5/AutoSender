using AutoSender.Dto;
using AutoSender.Models.Companys.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoSender.Services.Foundation.CompanyService
{
    public partial class CompanyService
    {
        public void validateEmail(string email)
        {
          if( ! Regex.IsMatch(email, email, RegexOptions.IgnoreCase))
            {
                throw new InvalidCompanyException(nameof(email),email);
            }
        }
        public void validateEntryIsNull(string entry)
        {
            if (string.IsNullOrEmpty(entry))
            {
                throw new InvalidCompanyException(nameof(entry), entry);
            }
        public void ValidateCompany(CompanyToAdd company)
        {
            if (company is null)
            {
                throw new NullCompanyException();
            }
        }
    }
}
