using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleCarSaleApp.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCarSaleApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarModel> CarModel { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<DriveType> DriveType { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }
        public DbSet<Fuel> Fuel { get; set; }
        public DbSet<Transmission> Transmission { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<CarImage> CarImage { get; set; }
    }
}
