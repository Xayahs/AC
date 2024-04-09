using ACModel.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManage;

namespace AC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult User()
        {
            return View();
        }

        public ActionResult Order()
         {
            return View();
        }

        public ActionResult TeaMenu()
        {
            return View();
        }

        public ActionResult Combo()
        {
            return View();
        }

        public ActionResult VIP()
        {
            return View();
        }


        public JsonResult GetUserList(PageParameter page)
        {
            var list = new UserMan().GetUserList(page);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }

        public JsonResult GetOrderList(PageParameter page)
        {
            var list = new UserMan().GetOrderList(page);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }
        public JsonResult GetTeaMenuList(PageParameter page)
        {
            var list = new UserMan().GetTeaMenuList(page);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }

        public JsonResult GetCombo(PageParameter page)
        {
            var list = new UserMan().GetCombo(page);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }

        public JsonResult GetVIP(PageParameter page)
        {
            var list = new UserMan().GetVIP(page);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }


        public JsonResult SelectList(PageParameter page,string condition,string num)
        {
            var list = new UserMan().SelectUserList(page, condition, num);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }
        public JsonResult SelectOrderList(PageParameter page, string condition, string num)
        {
            var list = new UserMan().SelectOrderList(page, condition, num);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }
        
        public JsonResult SelectTeaMenuTableList(PageParameter page, string condition, string num)
        {
            var list = new UserMan().SelectTeaMenuTableList(page, condition, num);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }

        public JsonResult SelectOrderListBy(PageParameter page, string condition, string num)
        {
            var list = new UserMan().SelectOrderList(page, condition, num);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }

       public JsonResult SelectCombo(PageParameter page, string condition, string num)
        {
            var list = new UserMan().SelectCombo(page, condition, num);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }

        public JsonResult SelectVIP(PageParameter page, string condition, string num)
        {
            var list = new UserMan().SelectVIP(page, condition, num);
            var str = JsonConvert.SerializeObject(list);
            return Json(str);
        }



        public JsonResult UpdateUserList(string name,string num)
        {
            new UserMan().UpdateUserList(name,num);
            return Json("修改成功");
        }

        public JsonResult UpdateOrderList(string name, string num)
        {
            new UserMan().UpdateOrderList(name, num);
            return Json("修改成功");
        }

        public JsonResult UpdateTeaMenuList(string name, string num)
        {
            new UserMan().UpdateTeaMenuList(name, num);
            return Json("修改成功");
        }

        public JsonResult UpdateCombo(string name, string num)
        {
            new UserMan().UpdateCombo(name, num);
            return Json("修改成功");
        }

        public JsonResult UpdateVIP(string name, string num)
        {
            new UserMan().UpdateVIP(name, num);
            return Json("修改成功");
        }

        public JsonResult DeleteTable(string num)
        {
              new UserMan().DeleteList(num);
              return Json("删除成功");
        }
        public JsonResult DeleteCombo(string num)
        {
            new UserMan().DeleteCombo(num);
            return Json("删除成功");
        }
        public JsonResult DeleteVIP(string num)
        {
            new UserMan().DeleteVIP(num);
            return Json("删除成功");
        }
        public JsonResult DeleteOrderTable(string num)
        {
            new UserMan().DeleteOrderList(num);
            return Json("删除成功");
        }

        public JsonResult DeleteTeaMenuTable(string num)
        {
            new UserMan().DeleteTeaMenuTable(num);
            return Json("删除成功");
        }

    }
}