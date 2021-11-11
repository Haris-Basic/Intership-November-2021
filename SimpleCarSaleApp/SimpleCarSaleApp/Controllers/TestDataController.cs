using Microsoft.AspNetCore.Mvc;
using SimpleCarSaleApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCarSaleApp.Controllers
{
    public class TestDataController : Controller
    {
        private ApplicationDbContext db;

        public TestDataController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            DbIncijalizator.Generate(db);

            return View(db);
        }
    }
}
