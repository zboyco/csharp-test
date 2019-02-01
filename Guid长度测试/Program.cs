using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guid长度测试
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                var g = Guid.NewGuid().ToByteArray();
                Console.WriteLine(g.Length);
            }
            Console.ReadKey();
        }
    }
}
