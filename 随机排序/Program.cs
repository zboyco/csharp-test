using System;
using System.Collections.Generic;

namespace 随机排序
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Random random = new Random();
            List<int> newList = new List<int>();
            foreach (var item in list)
            {
                newList.Insert(random.Next(newList.Count), item);
            }
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
