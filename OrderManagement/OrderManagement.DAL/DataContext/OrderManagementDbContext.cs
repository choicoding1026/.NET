using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.DAL.DataContext
{
    public class OrderManagementDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public OrderManagementDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Notice> Notices { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("LocalDbConnection"));
        }
    }
}
