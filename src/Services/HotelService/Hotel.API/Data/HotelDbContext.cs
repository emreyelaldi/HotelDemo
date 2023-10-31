using Hotel.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel.API.Data
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Entities.Hotel> Hotels { get; set; }
        public DbSet<Contact> Contacts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");

                var configuration = configBuilder.Build();
                string connectionString = configuration.GetConnectionString("SqlServer");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Hotel>().HasKey(x => x.UUID);
            modelBuilder.Entity<Contact>().HasKey(x => x.UUID);

        }
    }

}

