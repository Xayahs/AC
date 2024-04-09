using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACModel;
using ACModel.SqlSugar;
using Model.Tables;

namespace FoodService
{
    public class FoodSer
    {
        public List<TeaMenu> GetMilkTea()
        {
            var list = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.Type == "超人气奶茶").ToList();
            return list;
        }

        public List<TeaMenu> GetFruitTea()
        {
            var list = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.Type == "时令水果茶").ToList();
            return list;
        }

        public List<TeaMenu> GetColdTea()
        {
            var list = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.Type == "冷萃茶").ToList();
            return list;
        }

        public List<TeaMenu> GetLittle()
        {
            var list = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.Type == "加料区").ToList();
            return list;
        }

        public List<Combo> GetCombo()
        {
            var list = SugarHelper.Db.Queryable<Combo>().ToList();
            return list;
        }


        public void AddOrder(Order order)
        {
            SugarHelper.Db.Insertable(order).ExecuteCommand();
        }

        public void AddCustomer(string id, string name,string address,string tel)
        {
            var custom = SugarHelper.Db.Queryable<Customer>().Where(p => p.UserName == name).ToList();
            if (custom.Count == 0)
            {
                var list = SugarHelper.Db.Queryable<Order,Ac_User>((a,b)=>a.ID==id)
                    .Select((a,b)=>new Customer{ID=a.ID,UserName=b.UserName,Address=address,Spend=a.Price,Tel=tel})
                    .ToList();
                SugarHelper.Db.Insertable<Customer>(list).ExecuteCommand();
            }
            else
            {
                var money2 = SugarHelper.Db.Queryable<Order>().Where(p => p.ID == id).ToList();
                var money = Convert.ToInt32(custom[0].Spend);
                var money3 = Convert.ToInt32(money2[0].Price);
                money += money3;
                SugarHelper.Db.Updateable<Customer>().SetColumns(p => p.Spend == money.ToString()).Where(p => p.UserName ==name).ExecuteCommand();
            }
        }



    }
}
