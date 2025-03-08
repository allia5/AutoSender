using AutoSender.Models.Companys;
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
        public DbSet<Company> companies { get; set; }
        public async ValueTask<IQueryable<Company>> SelectAllCompany()
        {
            var DbContext = new StorageBroker();
            var Companys = await DbContext.companies.ToListAsync();
            return companies.AsQueryable();
        }
        public async ValueTask<Company> InsertCompany(Company company)
        {
            var DbContext = new StorageBroker();
            var Company = await DbContext.companies.AddAsync(company);
            await DbContext.SaveChangesAsync();
            return Company.Entity;

        }
    }
}
