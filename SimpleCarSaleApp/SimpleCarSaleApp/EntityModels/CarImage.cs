using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCarSaleApp.EntityModels
{
    public class CarImage
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int ImageID { get; set; }
        public Image Image { get; set; }
    }
}
