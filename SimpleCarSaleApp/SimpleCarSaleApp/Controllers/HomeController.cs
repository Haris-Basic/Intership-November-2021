using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCarSaleApp.Data;
using SimpleCarSaleApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCarSaleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<ShowCarsVM> model = _db.Car
                .Where(w => w.IsDeleted == false)
                .Select(s => new ShowCarsVM
                {
                    CarId = s.ID,
                    Brand = s.brand.BrandName,
                    CarModel = s.Model,
                    NumberOfSeats = s.NumberOfSeats,
                    NumberOfDors = s.NumberOfDors,
                    NumberOfGears = s.NumberOfGears,
                    PowerKw = s.PowerKw,
                    PowerPS = s.PowerPS,
                    Ccm = s.Ccm,
                    WheelSize = s.WheelSize,
                    Kilometre = s.Kilometre,
                    DateOfManufacture = s.DateOfManufacture,
                    Fuel = s.Fuel.FuelName,
                    VehicleType = s.VehicleType.TypeName,
                    Color = s.Color.ColorName,
                    DriveType = s.DriveType.DriveTypeName,
                    Transmission = s.Transmission.TransmissionType
                }).ToList();

            foreach (var item in model)
            {
                var carImageSET = _db.CarImage.Where(x => x.CarID == item.CarId).ToList();
                var AllImages = new List<string>();

                foreach (var slika in carImageSET)
                {
                    var ImageEntity = _db.Image.Where(i => i.ID == slika.ImageID).Select(i => i.PathToImage).FirstOrDefault();
                    AllImages.Add(ImageEntity);
                }
                item.images = AllImages;
            }
            return View(model);
        }

        [Authorize]
        public IActionResult AdminIndex()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
