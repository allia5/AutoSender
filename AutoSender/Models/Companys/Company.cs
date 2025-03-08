using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Models.Companys
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string JobTitle { get; set; }
        public StatusCompany StatusCompany { get; set; }
        public int Occurs { get; set; }
    }
}
