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
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=ErdemDesktop;Initial Catalog=ShopDb;Integrated Security=true;Encrypt=False");
        }
    }
}
