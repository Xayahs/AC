using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginManage;
using EmailHelper;
using ACModel;
using Model.Tables;
using IDHelper;

namespace AC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sign()
        {
            return View();
        }



        public JsonResult Login(string username,string pwd)
        {
            LoginMan loginMan = new LoginMan();
            if (loginMan.Login(username, pwd))
            {
                return Json("登录成功");
            }
            else return Json("登录失败");
        }

        public JsonResult SignIn(User user)
        {


            if (user.yzm == null || user.yzm == "")
            {
                return Json("验证码为空");
            }
            if (HttpContext.Session[user.Email] == null)
            {
                return Json("还未获取验证码，请先获取验证码");
            }
            if (user.yzm != HttpContext.Session[user.Email].ToString())
            {
                return Json("验证码错误，请重新输入");
            }

            LoginMan loginMan = new LoginMan();
            user.ID = idhelper.GetID().ToString();
            var username = user.UserName;
            var name = user.Name;
            var pwd = user.Pwd;
            var email = user.Email;
            var id = user.ID;
            Ac_User users = new Ac_User();
            users.UserName = username;
            users.Name = name;
            users.Pwd = pwd;
            users.Email = email;
            users.ID = id;
            loginMan.Sign(users);


            return Json("注册成功");

        }




        public JsonResult GetValidation(string email)
        {
            var yzm = EmailHelper.emailHelper.SendEmail(email);
            HttpContext.Session[email] = yzm;
            return Json("true");
        }



    }
}