using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDHelper
{
    public static class idhelper
    {
        public static long GetID()
        {
            var a = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(a, 0);
          }
    }
}
