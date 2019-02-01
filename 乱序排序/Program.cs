using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 乱序排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CardGoodwillStoriesSort());
            Console.ReadKey();
        }

        /// <summary>
        /// 好感剧情随机排序
        /// </summary>
        /// <returns></returns>
        private static string CardGoodwillStoriesSort()
        {
            StringBuilder sortStr = new StringBuilder();
            var rd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 5; i++)
            {
                List<int> list = Enumerable.Range(i * 6 + 1, 6).ToList();
                list = RandomSort(list);
                sortStr.Append(string.Join(",", list) + ",");
            }
            return sortStr.ToString();
        }

        /// <summary>
        /// 乱序排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> RandomSort(List<int> list)
        {
            var result = new int[list.Count].ToList();
            var rd = new Random(Guid.NewGuid().GetHashCode());
            foreach (var item in list)
            {
                result.Remove(result.Last(m => m == 0));
                result.Insert(rd.Next(10000) / (10000 / list.Count), item);
            }
            return result;
        }
    }
}
