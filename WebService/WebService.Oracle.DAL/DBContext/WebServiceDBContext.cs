using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebService.Model;

namespace WebService.Oracle.DAL.DBContext
{
    public class WebServiceDBContext : DbContext
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
            optionsBuilder.UseOracle(_configuration.GetConnectionString("OracleDBConnection"));
        }
    }
}
