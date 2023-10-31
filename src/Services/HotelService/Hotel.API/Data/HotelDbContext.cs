using Hotel.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel.API.Data
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Entities.Hotel> Hotels { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }

        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

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
            modelBuilder.Entity<ContactInfo>().HasKey(x => x.UUID);

            var hotelId1 = Guid.NewGuid();
            var hotelId2 = Guid.NewGuid();
            var hotelId3 = Guid.NewGuid();

            modelBuilder.Entity<ContactInfo>()
           .HasData(
                    new ContactInfo { UUID = Guid.NewGuid(), HotelUUID = hotelId1, InfoType = Enums.InfoType.Phone, InfoContent = "0 555 4443322" },
                    new ContactInfo { UUID = Guid.NewGuid(), HotelUUID = hotelId1, InfoType = Enums.InfoType.Email, InfoContent = "sunhotel@mail.com" },
                    new ContactInfo { UUID = Guid.NewGuid(), HotelUUID = hotelId1, InfoType = Enums.InfoType.Location, InfoContent = "Antalya" },
                    new ContactInfo { UUID = Guid.NewGuid(), HotelUUID = hotelId2, InfoType = Enums.InfoType.Phone, InfoContent = "0 533 5558899" },
                    new ContactInfo { UUID = Guid.NewGuid(), HotelUUID = hotelId2, InfoType = Enums.InfoType.Email, InfoContent = "moonhotel@mail.com" },
                    new ContactInfo { UUID = Guid.NewGuid(), HotelUUID = hotelId3, InfoType = Enums.InfoType.Email, InfoContent = "royalhotel@mail.com" }

                    );


            modelBuilder.Entity<Entities.Hotel>()
            .HasData(
              new Entities.Hotel
              {
                  UUID = hotelId1,
                  AuthorizedFirstName = "Ali",
                  AuthorizedLastName = "Demir",
                  CompanyTitle = "Sun Hotel"

              },
              new Entities.Hotel
              {
                  UUID = hotelId2,
                  AuthorizedFirstName = "Veli",
                  AuthorizedLastName = "Öz",
                  CompanyTitle = "Moon Hotel"

              },
              new Entities.Hotel
              {
                  UUID = hotelId3,
                  AuthorizedFirstName = "Ahmet",
                  AuthorizedLastName = "Duman",
                  CompanyTitle = "Royal Hotel"
              }

          );



        }
    }

}

