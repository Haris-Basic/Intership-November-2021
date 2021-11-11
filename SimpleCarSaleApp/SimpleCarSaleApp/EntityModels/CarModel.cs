﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCarSaleApp.EntityModels
{
    public class CarModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }

    }
}
