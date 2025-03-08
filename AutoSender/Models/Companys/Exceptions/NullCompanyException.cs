using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Models.Companys.Exceptions
{
    public class NullCompanyException:Exception
    {
        public NullCompanyException()
         : base(message: "Null Company. Please fix the errors and try again.") { }
    }
}
