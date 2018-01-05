using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Web.ViceVersa.Controllers
{
    /// <summary>
    /// MVC Controller
    /// 存放调用显示登录后教师相关界面的方法的控制器
    /// @author Group ViceVersa
    /// </summary>
    [Route("/Teacher")]
    public class TeacherController : Controller
    {
        /// <summary>
        /// 显示教师创建话题页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/CreateTopic")]
        public IActionResult CreateTopic()
        {
            return View();
        }

        /// <summary>
        /// 显示教师评分页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/TeacherScoreHome")]
        public IActionResult TeacherScoreHome()
        {
            return View();
        }

        /// <summary>
        /// 显示教师课前查看话题页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/CheckTopicBeforeClass")]
        public IActionResult CheckTopicBeforeClass()
        {
            return View();
        }

        /// <summary>
        /// 显示教师对报告打分页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/TeacherScoreReport")]
        public IActionResult TeacherScoreReport()
        {
            return View();
        }

        /// <summary>
        /// 显示教师基本信息页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/BasicInfo")]
        public IActionResult BasicInfo()
        {
            return View();
        }

        /// <summary>
        /// 显示教师教师课程主页的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/TeacherCourseHome")]
        public IActionResult TeacherCourseHome()
        {
            return View();
        }

        /// <summary>
        /// 显示教师创建班级的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/CreateClass")]
        public IActionResult CreateClass()
        {
            return View();
        }

        /// <summary>
        /// 显示教师创建课程的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/CreateCourse")]
        public IActionResult CreateCourse()
        {
            return View();
        }

        /// <summary>
        /// 显示教师课程信息页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/TeacherCourseInformation")]
        public IActionResult TeacherCourseInformation()
        {
            return View();
        }

        /// <summary>
        /// 显示教师查看班级信息页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/CheckClassInfo")]
        public IActionResult CheckClassInfo()
        {
            return View(); 
        }

        /// <summary>
        /// 显示教师查看话题页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/CheckTopic")]
        public IActionResult CheckTopic()
        {
            return View();
        }

        /// <summary>
        /// 显示教师创建讨论课页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/CreateSeminar")]
        public IActionResult CreateSeminar()
        {
            return View();
        }

        /// <summary>
        /// 显示教师修改课程信息页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/ModifyCourse")]
        public IActionResult ModifyCourse()
        {
            return View();
        }

        /// <summary>
        /// 显示教师查看话题选择页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/CheckTopicSelection")]
        public IActionResult CheckTopicSelection()
        {
            return View();
        }

        /// <summary>
        /// 显示教师查看讨论课信息页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Teacher/CheckSeminar")]
        public IActionResult CheckSeminar()
        {
            return View();
        }
    }
}