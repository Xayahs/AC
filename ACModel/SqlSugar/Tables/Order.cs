using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Model.Tables
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Order")]
    public partial class Order
    {
           public Order(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Content {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Price {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Time {get;set;}

    }
}
