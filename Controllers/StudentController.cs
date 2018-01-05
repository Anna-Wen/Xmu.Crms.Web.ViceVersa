using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Web.ViceVersa.Controllers
{
    /// <summary>
    /// MVC Controller
    /// 存放调用显示登录后学生相关界面的方法的控制器
    /// @author Group ViceVersa
    /// </summary>
    [Route("/Student")]
    public class StudentController : Controller
    {
        /// <summary>
        /// 显示学生基本信息页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Student/BasicInfo")]
        public IActionResult BasicInfo()
        {
            return View();
        }

        /// <summary>
        /// 显示学生课程总览主页的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Student/StudentCourseHome")]
        public IActionResult StudentCourseHome()
        {
            return View();
        }

        /// <summary>
        /// 显示学生讨论课页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Student/DiscussionClass")]
        public IActionResult DiscussionClass()
        {
            return View();
        }

        /// <summary>
        /// 显示学生课程主页的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Student/CourseHome")]
        public IActionResult CourseHome()
        {
            return View();
        }

        /// <summary>
        /// 显示学生浏览话题页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Student/ViewTopic")]
        public IActionResult ViewTopic()
        {
            return View();
        }

        /// <summary>
        /// 显示学生浏览小组信息页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Student/ViewGroup")]
        public IActionResult ViewGroup()
        {
            return View();
        }

        /// <summary>
        /// 显示学生选择课程页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Student/ChooseCourse")]
        public IActionResult ChooseCourse()
        {
            return View();
        }

        /// <summary>
        /// 显示学生查看分数页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Student/ViewGrade")]
        public IActionResult ViewGrade()
        {
            return View();
        }
    }
}