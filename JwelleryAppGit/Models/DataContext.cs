using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelleryApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id=1,
                    CustomerName="John",
                    UserName="John",
                    Password="John@123",
                    CustomerType= "Normal"
                },
                new Customer
                {
                    Id = 2,
                    CustomerName = "Bob",
                    UserName = "Bob",
                    Password = "Bob@123",
                    CustomerType = "Privileged"
                }
                );
        }
    }
}
