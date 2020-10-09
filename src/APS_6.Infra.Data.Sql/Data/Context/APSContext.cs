using APS_6.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace APS_6.Infra.Data.Sql.Data.Context
{
    public class APSContext : DbContext
    {
        readonly AppConfiguration appConfiguration = new AppConfiguration();

        public APSContext() : base()
        { }

        public APSContext(DbContextOptions<APSContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(appConfiguration.ConnectionString);
        }
    }
}
