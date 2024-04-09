using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using FoodManage;
using Model.Tables;

namespace AC.Controllers
{
    public class FrontController : Controller
    {
        // GET: Front
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Food()//奶茶
        {
            return View();
        }

        public ActionResult FruitTea()//水果茶
        {
            return View();
        }

        public ActionResult ColdTea()//冷萃茶
        {
            return View();
        }

        public ActionResult Little()//小料
        {
            return View();
        }

        public ActionResult Combo() //套餐
        {
            return View();
        }

        public ActionResult UserCom() //用户在本店的消费记录
        {
            return View();
        }



        

        //获取奶茶表
        public JsonResult GetMilkTea()
        {
            var list = new FoodMan().GetMilkTea();
            return Json(list);

        }

        //获得水果茶表
        public JsonResult GetFruitTea()
        {
            var list = new FoodMan().GetFruitTea();
            return Json(list);
        }

        //获得冷萃茶表
        public JsonResult GetColdTea()
        {
            var list = new FoodMan().GetColdTea();
            return Json(list);
        }

        //获得小料表
        public JsonResult GetLittle()
        {
            var list = new FoodMan().GetLittle();
            return Json(list);
        }

        public JsonResult GetCombo()
        {
            var list = new FoodMan().GetCombo();
            return Json(list);
        }


        //生成订单
        public JsonResult AddOrder(Order order)
        {
            if (order.Content == null) return Json("订单为空");
                 
            new FoodMan().AddOrder(order);
            return Json("订单生成成功");
        }

    }
}