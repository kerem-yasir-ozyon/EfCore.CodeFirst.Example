using EfCore.CodeFirst.Example.Context.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.Example.Context
{
    public class ShopDbContext : DbContext
    {
        //public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeInfo> EmployeesInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=ErdemDesktop;Initial Catalog=ShopDb;Integrated Security=true;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Customer>().HasKey(c => c.CustomerNumber);
            //modelBuilder.Entity<Customer>().Property(c => c.CustomerNumber).UseIdentityColumn(5,10);
            //modelBuilder.Entity<Customer>().Property(c =>c.SurName).HasMaxLength(10).IsUnicode(false); // char(5)
            //modelBuilder.Entity<Customer>().Property(c => c.Address).IsFixedLength().HasMaxLength(50).IsUnicode(true); // nchar(5)
            //modelBuilder.Entity<Customer>().Property(c => c.Email).IsRequired(); // girilmesi zorunlu

            modelBuilder.Entity<Employee>()
                        .HasOne(e => e.EmployeeInfo)
                        .WithOne(ei => ei.Employee)
                        .HasForeignKey<EmployeeInfo>(ei => ei.Id);

            
        }
    }
}
