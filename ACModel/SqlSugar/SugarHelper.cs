﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACModel.SqlSugar
{
    public static class SugarHelper
    {
        public static SqlSugarClient Db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "data source=127.0.0.1,56326;initial catalog=AC_DB;persist security info=True;user id=sa;password=123;MultipleActiveResultSets=True;",
            DbType = DbType.SqlServer,
            IsAutoCloseConnection = true
        },
           db => {
               //5.1.3.24统一了语法和SqlSugarScope一样，老版本AOP可以写外面

               db.Aop.OnLogExecuting = (sql, pars) =>
               {
                   Console.WriteLine(sql);//输出sql,查看执行sql 性能无影响

                   //5.0.8.2 获取无参数化SQL 对性能有影响，特别大的SQL参数多的，调试使用
                   //UtilMethods.GetSqlString(DbType.SqlServer,sql,pars)
               };

                   //注意多租户 有几个设置几个
                   //db.GetConnection(i).Aop

           });
    }
}
