using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Models.Companys.Exceptions
{
    public class CompanyValidationException : Exception
    {
        public CompanyValidationException(Exception exception) : base(message :"validation Exception . contact support",exception) { }
    }
}
