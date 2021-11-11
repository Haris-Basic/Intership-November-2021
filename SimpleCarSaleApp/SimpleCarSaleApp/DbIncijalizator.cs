using SimpleCarSaleApp.Data;
using SimpleCarSaleApp.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCarSaleApp
{
    public class DbIncijalizator
    {
        public static void Generate(ApplicationDbContext db)
        {

            var _Color = new List<Color>();
            var _Brand = new List<Brand>();
            var _DriveType = new List<DriveType>();
            var _VehicleType = new List<VehicleType>();
            var _Fuel = new List<Fuel>();
            var _Transmission = new List<Transmission>();

            _Color.Add(new Color { ColorName = "Red" });
            _Color.Add(new Color { ColorName = "Green" });
            _Color.Add(new Color { ColorName = "Blue" });
            _Color.Add(new Color { ColorName = "Black" });
            _Color.Add(new Color { ColorName = "Grey" });

            _Brand.Add(new Brand { BrandName = "BMW" });
            _Brand.Add(new Brand { BrandName = "Mercedes-Benz" });
            _Brand.Add(new Brand { BrandName = "Audi" });
            _Brand.Add(new Brand { BrandName = "Volkswagen" });

            _DriveType.Add(new DriveType { DriveTypeName = "RWD" });
            _DriveType.Add(new DriveType { DriveTypeName = "FWD" });
            _DriveType.Add(new DriveType { DriveTypeName = "AWD" });

            _VehicleType.Add(new VehicleType { TypeName = "SEDAN" });
            _VehicleType.Add(new VehicleType { TypeName = "COUPE" });
            _VehicleType.Add(new VehicleType { TypeName = "MINIVAN" });
            _VehicleType.Add(new VehicleType { TypeName = "SPORTS CAR" });
            _VehicleType.Add(new VehicleType { TypeName = "STATION WAGON" });
            _VehicleType.Add(new VehicleType { TypeName = "HATCHBACK" });
            _VehicleType.Add(new VehicleType { TypeName = "PICKUP TRUCK" });

            _Fuel.Add(new Fuel { FuelName = "Gasoline" });
            _Fuel.Add(new Fuel { FuelName = "Disel" });
            _Fuel.Add(new Fuel { FuelName = "Electro" });
            _Fuel.Add(new Fuel { FuelName = "Hybride" });

            _Transmission.Add(new Transmission { TransmissionType = "Automatic" });
            _Transmission.Add(new Transmission { TransmissionType = "Manual" });
            _Transmission.Add(new Transmission { TransmissionType = "Automated Manual" });
            _Transmission.Add(new Transmission { TransmissionType = "Continuously Variable" });

            db.AddRange(_Color);
            db.AddRange(_Brand);
            db.AddRange(_DriveType);
            db.AddRange(_VehicleType);
            db.AddRange(_Fuel);
            db.AddRange(_Transmission);

            db.SaveChanges();

            foreach (var item in db.Brand)
            {
                for (int i = 0; i < 5; i++)
                {
                    db.Add(new CarModel
                    {
                        Name = item.BrandName + " model " + (i + 1),
                        BrandID = item.ID,
                        Brand = item
                    });
                }
            }

            db.SaveChanges();
        }
    }
}

