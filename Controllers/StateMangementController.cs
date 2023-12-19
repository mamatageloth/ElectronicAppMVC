using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicsAppMVC.Models;

namespace ElectronicsAppMVC.Controllers
{
    public class StateMangementController : Controller
    {
        public IActionResult Index()
        {
            string username="";
            if (TempData.ContainsKey("username1")) {
                username = TempData["username1"].ToString();
            }
            return View();
        }
        public IActionResult viewDataTest()
        {
            ViewData["CompanyName"] = "CloudKampus Ltd";
            ViewData["CompanyContact"] = 89524525;
            return View();
        }
        public IActionResult viewBagTest()
        {
            ViewBag.CompanyName = "CloudKampus Ltd";
            ViewBag.CompanyContact = 89524525;
            return View();
        }
        [HttpPost]
        public IActionResult viewBagTest(User user)
        {
            ViewBag.username = user.username;
            ViewBag.password = user.passward;
            TempData["username1"] = user.username;
            if (ViewBag.username == "Admin" && ViewBag.password == "Admin123")
            {
                return RedirectToAction("Index");
            }
            else {
                ViewBag.errormessage = "Invalid Username or password";
                return View();
            }
           
            
        }
        public IActionResult reset() {
            return View();
        }
        public IActionResult HTMLBootstrapGrid()
        {
            return View();
        }
    }
}
