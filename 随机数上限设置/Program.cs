using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机数上限设置
{
    class Program
    {
        static void Main(string[] args)
        {
            var _rd = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(_rd.Next(1, 3));
            }

            Console.ReadKey();
        }
    }
}
