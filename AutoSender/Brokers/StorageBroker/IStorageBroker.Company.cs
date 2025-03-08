using AutoSender.Models.Companys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Brokers.StorageBroker
{
    public partial interface IStorageBroker
    {
        public ValueTask<Company> InsertCompany(Company company);
        public ValueTask<IQueryable<Company>> SelectAllCompany();
    }
}
