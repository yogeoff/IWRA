using IWRA_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace IWRA_Web.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public  AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }

        public DbSet<Assignee> Assignee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
