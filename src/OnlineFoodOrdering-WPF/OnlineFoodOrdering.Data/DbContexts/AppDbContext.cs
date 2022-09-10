using Microsoft.EntityFrameworkCore;
using OnlineFoodOrdering.Domain.Constants;
using OnlineFoodOrdering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(DBConstants.connectionString);
        }
    }
}
