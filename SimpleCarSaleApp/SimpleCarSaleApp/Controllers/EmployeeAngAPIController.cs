using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCarSaleApp.Data;
using SimpleCarSaleApp.EntityModels;
using SimpleCarSaleApp.Models.AngularVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCarSaleApp.Controllers
{
    [Produces("application/json")]
    public class EmployeeAngAPI : Controller
    {
        private ApplicationDbContext _db;
        public EmployeeAngAPI(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetBrands()
        {
            var model = _db.Brand.Select(s => new
            {
                id = s.ID,
                name = s.BrandName
            }).ToList();

            return Json(model);
        }
        [HttpPost]
        public IActionResult AddBrand([FromBody] AddBrand model)
        {
            Brand temp = new Brand();
            temp.BrandName = model.name;
            _db.Add(temp);
            _db.SaveChanges();

            return Ok(model);
        }

        public IActionResult EditBrand([FromBody] AddBrand model)
        {
            var x = _db.Brand.Find(model.id);
            x.BrandName = model.name;
            _db.SaveChanges();

            return Ok(model);
        }
        public IActionResult DeleteBrand(int id)
        {
            var x = _db.Brand.Where(w => w.ID == id).FirstOrDefault();
            var list = _db.CarModel.Where(w => w.BrandID == id).ToList();
            _db.RemoveRange(list);
            _db.Remove(x);
            _db.SaveChanges();
            return Ok();
        }

        /*------------------------------------------------------------------------------*/
        public IActionResult GetModelByBrandId()
        {
            var model = _db.CarModel
                //.Where(w => w.BrandID == id)
                .Include(c => c.Brand)
                .Select(s => new BrandModelVM
                {
                    brandid = s.BrandID,
                    brandname = s.Brand.BrandName,
                    modelid = s.ID,
                    modelname = s.Name
                }).ToList();

            return Ok(model);
        }
        public IActionResult AddModel([FromBody] BrandModelVM model)
        {
            var x = new CarModel
            {
                BrandID = model.brandid,
                Name= model.modelname
            };
            _db.Add(x);
            _db.SaveChanges();
            return Ok();
        }

        public IActionResult EditModel([FromBody] BrandModelVM model)
        {
            var x = _db.CarModel.Find(model.modelid);
            x.Name = model.modelname;
            _db.SaveChanges();

            return Ok();
        }

        public IActionResult DeleteModel(int id)
        {
            var x = _db.CarModel.Where(w => w.ID == id).FirstOrDefault();
            _db.Remove(x);
            _db.SaveChanges();

            return Ok();
        }
    }
}
