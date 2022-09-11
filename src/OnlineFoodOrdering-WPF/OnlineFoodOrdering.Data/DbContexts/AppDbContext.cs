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
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<FoodType> FoodTypes { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Rating> Ratings { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(DBConstants.connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasIndex(x => x.Email)
                .IsUnique();
            modelBuilder.Entity<Customer>()
                .HasIndex(x => x.Login)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasIndex(x => x.Email)
                .IsUnique();
            modelBuilder.Entity<Employee>()
                .HasIndex(x => x.Login)
                .IsUnique();
        }
    }
}
