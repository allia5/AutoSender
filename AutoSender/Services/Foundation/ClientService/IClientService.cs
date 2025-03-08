using AutoSender.Models.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Services.Foundation.ClientService
{
    public partial interface IClientService
    {
        public ValueTask<IQueryable<Client>> RetrieveAllClient();
    }
}
