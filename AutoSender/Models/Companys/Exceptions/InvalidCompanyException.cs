using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Models.Companys.Exceptions
{
    public class InvalidCompanyException : Exception
    {
        public InvalidCompanyException(string parameterName, object parameterValue)
            : base(message: $"Invalid Company, " +
                  $"ParameterName: {parameterName}, " +
                  $"ParameterValue: {parameterValue}.")
        { }

        public InvalidCompanyException()
            : base(message: "Invalid Company. Please fix the errors and try again.") { }

    }
}
