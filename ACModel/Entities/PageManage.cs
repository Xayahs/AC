using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACModel.Entities
{
    public class PageManage<T> where T : class
    {
        public List<T> DataSources { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        public int PageTotal { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>

        public int PageCount { get; set; }
    }
}
