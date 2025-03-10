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

        public statusAddCompany Status { get; set; }
    }
    public  enum statusAddCompany
    {
        Add,
        NotAdd
    }
}
