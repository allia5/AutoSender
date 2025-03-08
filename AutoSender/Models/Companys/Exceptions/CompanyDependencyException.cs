using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Models.Companys.Exceptions
{
    public class CompanyDependencyException : Exception
    {
        public CompanyDependencyException(Exception exception) : base(message : "Service dependency error occurred, contact support.", exception) { }

    }
}
