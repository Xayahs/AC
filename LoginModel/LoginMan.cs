using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginService;
using ACModel;
using Model.Tables;

namespace LoginManage
{
    public class LoginMan
    {
        public bool Login(string username, string pwd)
        {

            LoginSer loginSer=new LoginSer();
            return loginSer.Login(username, pwd);
        }

        public void Sign(Ac_User user)
          {
            LoginSer loginSer = new LoginSer();
            loginSer.Sign(user);
        }


    }
}
