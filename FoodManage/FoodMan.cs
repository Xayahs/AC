using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACModel;
using Model.Tables;
using FoodService;

namespace FoodManage
{
    public class FoodMan
    {
       public List<TeaMenu> GetMilkTea()
        {
            return new FoodSer().GetMilkTea();
        }

        public List<Combo> GetCombo()
        {
            return new FoodSer().GetCombo();
        }

        public List<TeaMenu> GetFruitTea()
        {
            return new FoodSer().GetFruitTea();
        }
        public List<TeaMenu> GetColdTea()
        {
            return new FoodSer().GetColdTea();
        }

        public List<TeaMenu> GetLittle()
        {
            return new FoodSer().GetLittle();
        }



        public void AddOrder(Order order)
        {
            new FoodSer().AddOrder(order);
        }

        public void AddCustomer(string id, string name, string address, string tel)
        {
            new FoodSer().AddCustomer(id, name,address,tel);
        }


    }
}
