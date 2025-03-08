using AutoSender.Brokers.StorageBroker;
using AutoSender.Models.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Services.Foundation.ClientService
{
    public partial class ClientService : IClientService
    {
        protected readonly IStorageBroker storageBroker;
        public ClientService(IStorageBroker storageBroker) =>
            (this.storageBroker) = (storageBroker);

        public async ValueTask<IQueryable<Client>> RetrieveAllClient()
        {
            return await this.storageBroker.SelectAllClient();
        }
    }
}
