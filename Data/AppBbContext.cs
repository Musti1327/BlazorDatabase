using BlazorDB.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorDB.Data
{
    public class AppBbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppBbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DbConnectionstring"));
        }

        public DbSet<DataDB> DataDB { get; set; }
    }
}
