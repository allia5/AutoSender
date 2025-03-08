using AutoSender.Models.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Brokers.StorageBroker
{
    public partial interface IStorageBroker
    {
        public ValueTask<IQueryable<Client>> SelectAllClient();
    }
}
