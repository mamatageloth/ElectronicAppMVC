using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsAppMVC.Controllers
{
    public class HTMLHelperController : Controller
    {
        public IActionResult BasicHtml()
        {
            return View();
        }
        public IActionResult BasicHtmlBS()
        {
            return View();
        }
        public IActionResult BasicHtmlBSLayout()
        {
            return View();
        }
        public IActionResult StandardHtmlHelper()
        {
            return View();
        }
        public IActionResult StronglyHtmlHelper()
        {
            return View();
        }
        public IActionResult EditorHtmlHelper()
        {
            return View();
        }
    }
}
