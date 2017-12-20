using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Web.ViceVersa.Controllers
{
    [Route("/Student")]
    public class StudentController : Controller
    {
        [Route("/Student/BasicInfo")]
        public IActionResult BasicInfo()
        {
            return View();
        }

        [Route("/Student/StudentCourseHome")]
        public IActionResult StudentCourseHome()
        {
            return View();
        }

        [Route("/Student/DiscussionClass")]
        public IActionResult DiscussionClass()
        {
            return View();
        }

        [Route("/Student/CourseHome")]
        public IActionResult CourseHome()
        {
            return View();
        }

        [Route("/Student/ViewTopic")]
        public IActionResult ViewTopic()
        {
            return View();
        }

        [Route("/Student/ViewGroup")]
        public IActionResult ViewGroup()
        {
            return View();
        }

        [Route("/Student/ChooseCourse")]
        public IActionResult ChooseCourse()
        {
            return View();
        }

        [Route("/Student/ViewGrade")]
        public IActionResult ViewGrade()
        {
            return View();
        }
    }
}