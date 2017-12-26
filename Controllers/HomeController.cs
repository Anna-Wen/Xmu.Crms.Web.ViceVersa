using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Web.ViceVersa.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult HomePage()
        {
            return Redirect("/Home/AccountLogin");
        }

        [Route("/Home/AccountLogin")]
        public IActionResult AccountLogin()
        {
            return View();
        }

        [Route("/Home/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("/Home/CreateSchool")]
        public IActionResult CreateSchool()
        {
            return View();
        }

    }
}
