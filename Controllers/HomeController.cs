using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Web.ViceVersa.Controllers
{
    /// <summary>
    /// MVC Controller
    /// 存放调用显示登录相关界面的方法的控制器
    /// @author Group ViceVersa
    /// </summary>
    [Route("")]
    public class HomeController : Controller
    {
        /// <summary>
        /// 显示主页HomePage的方法（主页这里为AccountLogin，所以会跳转到“/Home/AccountLogin”路径）
        /// </summary>
        /// <returns></returns>
        [Route("/")]
        public IActionResult HomePage()
        {
            return Redirect("/Home/AccountLogin");
        }

        /// <summary>
        /// 显示登录页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Home/AccountLogin")]
        public IActionResult AccountLogin()
        {
            return View();
        }

        /// <summary>
        /// 显示注册页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Home/Register")]
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 显示新建学校页面的方法
        /// </summary>
        /// <returns></returns>
        [Route("/Home/CreateSchool")]
        public IActionResult CreateSchool()
        {
            return View();
        }
    }
}
