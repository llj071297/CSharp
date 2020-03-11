using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名类型
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new { name = "asd", age = 238 }; //这个就是匿名类型
            var data1 = new { name = "asd", age = 321, das = 132};
        }
    }
}
