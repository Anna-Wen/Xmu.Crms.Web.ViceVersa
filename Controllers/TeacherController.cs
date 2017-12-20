using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Web.ViceVersa.Controllers
{
    [Route("/Teacher")]
    public class TeacherController : Controller
    {
        [Route("/Teacher/CreateTopic")]
        public IActionResult CreateTopic()
        {
            return View();
        }

        [Route("/Teacher/TeacherScoreHome")]
        public IActionResult TeacherScoreHome()
        {
            return View();
        }

        [Route("/Teacher/CheckTopicBeforeClass")]
        public IActionResult CheckTopicBeforeClass()
        {
            return View();
        }

        [Route("/Teacher/TeacherScoreReport")]
        public IActionResult TeacherScoreReport()
        {
            return View();
        }

        [Route("/Teacher/BasicInfo")]
        public IActionResult BasicInfo()
        {
            return View();
        }

        [Route("/Teacher/TeacherCourseHome")]
        public IActionResult TeacherCourseHome()
        {
            return View();
        }

        [Route("/Teacher/CreateClass")]
        public IActionResult CreateClass()
        {
            return View();
        }

        [Route("/Teacher/CreateCourse")]
        public IActionResult CreateCourse()
        {
            return View();
        }

        [Route("/Teacher/TeacherCourseInformation")]
        public IActionResult TeacherCourseInformation()
        {
            return View();
        }

        [Route("/Teacher/CheckClassInfo")]
        public IActionResult CheckClassInfo()
        {
            return View(); 
        }

        [Route("/Teacher/CheckTopic")]
        public IActionResult CheckTopic()
        {
            return View();
        }

        [Route("/Teacher/CreateSeminar")]
        public IActionResult CreateSeminar()
        {
            return View();
        }

        [Route("/Teacher/ModifyCourse")]
        public IActionResult ModifyCourse()
        {
            return View();
        }    }
}