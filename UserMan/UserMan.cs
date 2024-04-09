using ACModel.Entities;
using Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService;

namespace UserManage
{
    public class UserMan
    {
        public PageManage<Ac_User> GetUserList(PageParameter page)
        {
            return new UserSer().GetUserList(page);
        }
        public PageManage<Order> GetOrderList(PageParameter page)
        {
            return new UserSer().GetOrderList(page);
        }

        public PageManage<TeaMenu> GetTeaMenuList(PageParameter page)
        {
            return new UserSer().GetTeaMenuList(page);
        }

        public PageManage<Combo> GetCombo(PageParameter page)
        {
            return new UserSer().GetCombo(page);
        }
        public PageManage<Customer> GetVIP(PageParameter page)
        {
            return new UserSer().GetVIP(page);
        }




        public PageManage<Ac_User> SelectUserList(PageParameter page, string condition, string num)
        {
            return new UserSer().SelectUserList(page,condition,num);
        }
        public PageManage<Order> SelectOrderList(PageParameter page, string condition, string num)
        {
            return new UserSer().SelectOrderList(page, condition, num);
        }

        public PageManage<TeaMenu> SelectTeaMenuTableList(PageParameter page, string condition, string num)
        {
            return new UserSer().SelectTeaMenuTableList(page, condition, num);
        }
        public PageManage<Combo> SelectCombo(PageParameter page, string condition, string num)
        {
            return new UserSer().SelectCombo(page, condition, num);
        }
        public PageManage<Customer> SelectVIP(PageParameter page, string condition, string num)
        {
            return new UserSer().SelectVIP(page, condition, num);
        }



        public void UpdateUserList(string name,string num)
        {
            new UserSer().UpdateUserList(name,num);
        }
        public void UpdateOrderList(string name, string num)
        {
            new UserSer().UpdateOrderList(name, num);
        }
        public void UpdateTeaMenuList(string name, string num)
        {
            new UserSer().UpdateTeaMenuList(name, num);
        }
        public void UpdateCombo(string name, string num)
        {
            new UserSer().UpdateCombo(name, num);
        }
        public void UpdateVIP(string name, string num)
        {
            new UserSer().UpdateVIP(name, num);
        }

        public void DeleteList(string name)
        {
            new UserSer().DeleteTable(name);
        }

        public void DeleteOrderList(string name)
        {
            new UserSer().DeleteOrderList(name);
        }
        public void DeleteTeaMenuTable(string name)
        {
            new UserSer().DeleteTeaMenuTable(name);
        }
        public void DeleteCombo(string name)
        {
            new UserSer().DeleteCombo(name);
        }
        public void DeleteVIP(string name)
        {
            new UserSer().DeleteVIP(name);
        }


    }
}
