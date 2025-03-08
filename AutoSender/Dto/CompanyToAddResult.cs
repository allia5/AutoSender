using AutoSender.Models.Companys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Dto
{
    public class CompanyToAddResult
    {
        public string Email { get; set; }

        public statusSnedEmail Status { get; set; }
    }
    public  enum statusSnedEmail
    {
        Add,
        NotAdd
    }
}
