using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机数重复测试
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new int[100];
            var _rd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 100; i++)
            {
                ints[i] = _rd.Next(101);
            }
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
