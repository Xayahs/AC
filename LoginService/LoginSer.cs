using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ACModel;
using ACModel.SqlSugar;
using Model.Tables;

namespace LoginService
{
    public class LoginSer
    {
        public bool Login(string username, string pwd)
        {

            var a = SugarHelper.Db.Queryable<Ac_User>().Where(p=>p.UserName==username && p.Pwd==pwd).ToList();
            if (a .Count==0) return false;
            else return true;   

        }

        public void Sign(Ac_User user)
        {
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
        SugarHelper.Db.Insertable(users).ExecuteCommand();
        }

    }
}
