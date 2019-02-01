using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造器测试
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Class1 {
                Number = 10
            };
            Console.WriteLine(obj.Number);
            Console.WriteLine(obj.Result);
            Console.ReadKey();
        }
    }
}
