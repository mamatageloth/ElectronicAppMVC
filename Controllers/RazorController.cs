using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsAppMVC.Controllers
{
    public class RazorController : Controller
    {
        //action method 
        public IActionResult RazorSyntax()
        {
            return View();
        }
    }
}
