using ACModel.Entities;
using ACModel.SqlSugar;
using Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class UserSer
    {
        public PageManage<Ac_User> GetUserList(PageParameter page)  //获取用户表
        {
            if(page==null||page.PageIndex==0)
            {
                var list = SugarHelper.Db.Queryable<Ac_User>().ToList();
                return new PageManage<Ac_User>() { DataSources = list ,PageTotal=list.Count};
            }
            var list2= SugarHelper.Db.Queryable<Ac_User>().Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            var count = SugarHelper.Db.Queryable<Ac_User>().Count();
            return new PageManage<Ac_User>() { DataSources = list2, PageTotal = count };
        }

        public PageManage<Order> GetOrderList(PageParameter page)  //获取订单表
        {
            if (page == null || page.PageIndex == 0)
            {
                var list = SugarHelper.Db.Queryable<Order>().ToList();
                return new PageManage<Order>() { DataSources = list, PageTotal = list.Count };
            }
            var list2 = SugarHelper.Db.Queryable<Order>().Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            var count = SugarHelper.Db.Queryable<Order>().Count();
            return new PageManage<Order>() { DataSources = list2, PageTotal = count };
        }

        public PageManage<TeaMenu> GetTeaMenuList(PageParameter page) //获取商品表
        {
            if (page == null || page.PageIndex == 0)
            {
                var list = SugarHelper.Db.Queryable<TeaMenu>().ToList();
                return new PageManage<TeaMenu>() { DataSources = list, PageTotal = list.Count };
            }
            var list2 = SugarHelper.Db.Queryable<TeaMenu>().Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            var count = SugarHelper.Db.Queryable<TeaMenu>().Count();
            return new PageManage<TeaMenu>() { DataSources = list2, PageTotal = count };
        }

        public PageManage<Combo> GetCombo(PageParameter page) //获取商品表
        {
            if (page == null || page.PageIndex == 0)
            {
                var list = SugarHelper.Db.Queryable<Combo>().ToList();
                return new PageManage<Combo>() { DataSources = list, PageTotal = list.Count };
            }
            var list2 = SugarHelper.Db.Queryable<Combo>().Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            var count = SugarHelper.Db.Queryable<Combo>().Count();
            return new PageManage<Combo>() { DataSources = list2, PageTotal = count };
        }

        public PageManage<Customer> GetVIP(PageParameter page) //获取商品表
        {
            if (page == null || page.PageIndex == 0)
            {
                var list = SugarHelper.Db.Queryable<Customer>().ToList();
                return new PageManage<Customer>() { DataSources = list, PageTotal = list.Count };
            }
            var list2 = SugarHelper.Db.Queryable<Customer>().Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            var count = SugarHelper.Db.Queryable<Customer>().Count();
            return new PageManage<Customer>() { DataSources = list2, PageTotal = count };
        }


        public PageManage<Ac_User> SelectUserList(PageParameter page, string condition, string num)  //查用户表
        {
            if(condition=="用户姓名")
            {
                if (page == null || page.PageIndex == 0)
                {
                    var list=SugarHelper.Db.Queryable<Ac_User>().Where(p =>p.UserName==num).ToList();
                    return new PageManage<Ac_User>() { DataSources = list, PageTotal = list.Count };
                }
                var list2 = SugarHelper.Db.Queryable<Ac_User>().Where(p => p.UserName == num).Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                var count = SugarHelper.Db.Queryable<Ac_User>().Where(p => p.UserName == num).Count();
                return new PageManage<Ac_User> { DataSources = list2, PageTotal = count };
            }
            else
            {
                if (page == null || page.PageIndex == 0)
                {
                    var list3 = SugarHelper.Db.Queryable<Ac_User>().Where(p => p.ID == num).ToList();
                    return new PageManage<Ac_User>() { DataSources = list3, PageTotal = list3.Count };
                }
                var list4 = SugarHelper.Db.Queryable<Ac_User>().Where(p => p.ID == num).Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                var count = SugarHelper.Db.Queryable<Ac_User>().Where(p => p.ID == num).Count();
                return new PageManage<Ac_User> { DataSources = list4, PageTotal = count };
            }
            
        }

        public PageManage<Order> SelectOrderList(PageParameter page, string condition, string num)   //查订单表
        {
                if (page == null || page.PageIndex == 0)
                {
                    var list = SugarHelper.Db.Queryable<Order>().Where(p => p.ID == num).ToList();
                    return new PageManage<Order>() { DataSources = list, PageTotal = list.Count };
                }
                var list2 = SugarHelper.Db.Queryable<Order>().Where(p => p.ID == num).Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                var count = SugarHelper.Db.Queryable<Order>().Where(p => p.ID == num).Count();
                return new PageManage<Order> { DataSources = list2, PageTotal = count };
        }

        public PageManage<TeaMenu> SelectTeaMenuTableList(PageParameter page, string condition, string num)
        {
            if (condition == "商品名称")
            {
                if (page == null || page.PageIndex == 0)
                {
                    var list = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.Name == num).ToList();
                    return new PageManage<TeaMenu>() { DataSources = list, PageTotal = list.Count };
                }
                var list2 = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.Name == num).Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                var count = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.Name == num).Count();
                return new PageManage<TeaMenu> { DataSources = list2, PageTotal = count };
            }
            else
            {
                if (page == null || page.PageIndex == 0)
                {
                    var list3 = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.ID == num).ToList();
                    return new PageManage<TeaMenu>() { DataSources = list3, PageTotal = list3.Count };
                }
                var list4 = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.ID == num).Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                var count = SugarHelper.Db.Queryable<TeaMenu>().Where(p => p.ID == num).Count();
                return new PageManage<TeaMenu> { DataSources = list4, PageTotal = count };
            }

        }
        public PageManage<Combo> SelectCombo(PageParameter page, string condition, string num)
        {
            if (condition == "套餐内容")
            {
                if (page == null || page.PageIndex == 0)
                {
                    var list = SugarHelper.Db.Queryable<Combo>().Where(p => p.Content == num).ToList();
                    return new PageManage<Combo>() { DataSources = list, PageTotal = list.Count };
                }
                var list2 = SugarHelper.Db.Queryable<Combo>().Where(p => p.Content == num).Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                var count = SugarHelper.Db.Queryable<Combo>().Where(p => p.Content == num).Count();
                return new PageManage<Combo> { DataSources = list2, PageTotal = count };
            }
            else
            {
                if (page == null || page.PageIndex == 0)
                {
                    var list3 = SugarHelper.Db.Queryable<Combo>().Where(p => p.ID == num).ToList();
                    return new PageManage<Combo>() { DataSources = list3, PageTotal = list3.Count };
                }
                var list4 = SugarHelper.Db.Queryable<Combo>().Where(p => p.ID == num).Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                var count = SugarHelper.Db.Queryable<Combo>().Where(p => p.ID == num).Count();
                return new PageManage<Combo> { DataSources = list4, PageTotal = count };
            }

        }
        public PageManage<Customer> SelectVIP(PageParameter page, string condition, string num)
        {
            if (condition == "会员名称")
            {
                if (page == null || page.PageIndex == 0)
                {
                    var list = SugarHelper.Db.Queryable<Customer>().Where(p => p.UserName == num).ToList();
                    return new PageManage<Customer>() { DataSources = list, PageTotal = list.Count };
                }
                var list2 = SugarHelper.Db.Queryable<Customer>().Where(p => p.UserName == num).Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                var count = SugarHelper.Db.Queryable<Customer>().Where(p => p.UserName == num).Count();
                return new PageManage<Customer> { DataSources = list2, PageTotal = count };
            }
            else
            {
                if (page == null || page.PageIndex == 0)
                {
                    var list3 = SugarHelper.Db.Queryable<Customer>().Where(p => p.ID == num).ToList();
                    return new PageManage<Customer>() { DataSources = list3, PageTotal = list3.Count };
                }
                var list4 = SugarHelper.Db.Queryable<Customer>().Where(p => p.ID == num).Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                var count = SugarHelper.Db.Queryable<Customer>().Where(p => p.ID == num).Count();
                return new PageManage<Customer> { DataSources = list4, PageTotal = count };
            }

        }

        public void UpdateUserList(string name, string num)
        {
            var result = SugarHelper.Db.Updateable<Ac_User>().SetColumns(p => p.UserName == num).Where(p => p.UserName == name).ExecuteCommand();
        }
        public void UpdateOrderList(string name, string num)
        {
            var result = SugarHelper.Db.Updateable<Order>().SetColumns(p => p.Content == num).Where(p => p.ID== name).ExecuteCommand();
        }

        public void UpdateTeaMenuList(string name, string num)
        {
            var result = SugarHelper.Db.Updateable<TeaMenu>().SetColumns(p => p.Price == num).Where(p => p.Name== name).ExecuteCommand();
        }
        public void UpdateCombo(string name, string num)
        {
            var result = SugarHelper.Db.Updateable<Combo>().SetColumns(p => p.Price == num).Where(p => p.Content == name).ExecuteCommand();
        }
        public void UpdateVIP(string name, string num)
        {
            var result = SugarHelper.Db.Updateable<Customer>().SetColumns(p => p.Spend == num).Where(p => p.UserName == name).ExecuteCommand();
        }

        public void DeleteTable(string name)
        {
            var result=SugarHelper.Db.Deleteable<Ac_User>().Where(p=>p.UserName==name).ExecuteCommand();
        }
        public void DeleteCombo(string name)
        {
            var result = SugarHelper.Db.Deleteable<Combo>().Where(p => p.ID == name).ExecuteCommand();
        }
        public void DeleteVIP(string name)
        {
            var result = SugarHelper.Db.Deleteable<Customer>().Where(p => p.ID == name).ExecuteCommand();
        }

        public void DeleteOrderList(string name)
        {
            var result = SugarHelper.Db.Deleteable<Order>().Where(p => p.ID == name).ExecuteCommand();
        }
        public void DeleteTeaMenuTable(string name)
        {
            var result = SugarHelper.Db.Deleteable<TeaMenu>().Where(p => p.ID == name).ExecuteCommand();
        }


        







    }
}
