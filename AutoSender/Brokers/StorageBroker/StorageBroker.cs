using AutoSender.Models.Clients;
using AutoSender.Models.Companys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSender.Brokers.StorageBroker
{
    public partial class StorageBroker :DbContext , IStorageBroker
    {
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\RAD ONE\\source\\repos\\AutoSender\\AutoSender\\Data\\AutoSender.db");

        }

      

      
    }
   
}
