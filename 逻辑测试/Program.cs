using System;
using System.Collections.Generic;
using System.Linq;

namespace 逻辑测试
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object> { 1, 2, 3 };

            var rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                List<object> result = new object[list.Count].ToList();

                foreach (var item in list)
                {
                    result.Remove(result.Last(m => m == null));
                    result.Insert((int)(rd.Next(10000) / (10000f / list.Count)), item);
                }
                Console.WriteLine(string.Join("-", result));
            }

            Console.ReadKey();
        }
    }
}
