using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using WebService.Model;

namespace WebService.DAL.DBContext
{
    public class WebServiceDBContext: DbContext
    {
        private readonly IConfiguration _configuration;

        public WebServiceDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Notice> Notices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SQLServerDBConnection"));
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WebServiceDb;");        
        }
    }
}
