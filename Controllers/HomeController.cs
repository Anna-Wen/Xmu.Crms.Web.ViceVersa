using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Web.ViceVersa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult AccountLogin()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult CreateSchool()
        {
            return View();
        }
    }
}
