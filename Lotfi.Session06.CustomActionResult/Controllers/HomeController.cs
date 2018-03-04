using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Lotfi.Session06.CustomActionResult.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }
        public IActionResult Contact()
        {
            return RedirectToAction("Index").WithDanger("Danger", " Fill from Contact");
        }
        public IActionResult About()
        {
            return RedirectToAction("Index").WithWarning("Warning", "Fill from About");
        }
    }
}