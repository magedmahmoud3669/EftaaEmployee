using Dal.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> opt) : base(opt)
        {
        }
      

        public DbSet<Lookups> Lookups { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<LookupsValue> LookupsValue { get; set; }

    }
}
