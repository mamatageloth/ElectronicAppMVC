using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//to access model class
using ElectronicsAppMVC.Models;

namespace ElectronicsAppMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //initialize values to a model class property
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.ProductId = 1;
            product.Name = "Apple iPad";
            product.Quantity = 15.00f;
            product.Price = 89000.56f;
            product.Image = "AppleIpad.jpg";
            products.Add(product);
            Product product1 = new Product();
            product1.ProductId = 2;
            product1.Name = "Logitech Keyboard";
            product1.Quantity = 25.00f;
            product1.Price = 5000.56f;
            product1.Image = "logitech.jpg";
            products.Add(product1);
            Product product3 = new Product();
            product3.ProductId = 3;
            product3.Name = "Portable SSD";
            product3.Quantity = 5.00f;
            product3.Price = 25000.56f;
            product3.Image = "portablessd.jpg";
            products.Add(product3);
            Product product4 = new Product();
            product4.ProductId = 4;
            product4.Name = "WIFI Extender";
            product4.Quantity = 15.00f;
            product4.Price = 8000.56f;
            product4.Image = "widiextender.jpg";
            products.Add(product4);

            return View(products);
        }
        public IActionResult AboutUs() {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
