using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Models.Companys.Exceptions
{
    public class CompanyServiceException : Exception
    {
      public CompanyServiceException(Exception exception) : base(message: "Service Exception occurred, contact support.", exception) { }
    }
}
