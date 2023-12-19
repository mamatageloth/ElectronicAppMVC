using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsAppMVC.Models
{
    //model class
    public class Product
    {
        //set of properties
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Quantity { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
    }
}
