using AutoSender.Models.Clients;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Brokers.StorageBroker
{
    public partial class StorageBroker
    {
        public DbSet<Client> clients { get; set; }
        public async ValueTask<IQueryable<Client>> SelectAllClient()
        {
            var DbContext = new StorageBroker();
            var Client = await DbContext.clients.ToListAsync();


            return Client.AsQueryable();
        }
    }
}
