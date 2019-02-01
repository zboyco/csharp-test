using System;

namespace 生成月份区间列表
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDateStr = "2018-05";
            string endDateStr = "2017-04";
            //DateTime startDate = DateTime.Parse(startDateStr);
            //DateTime endDate = DateTime.Parse(endDateStr);
            //while (startDate >= endDate)
            //{
            //    Console.WriteLine(startDate.ToString("yyyy-MM"));
            //    startDate = startDate.AddMonths(-1);
            //}
            int startYear = int.Parse(startDateStr.Split('-')[0]);
            int startMonth = int.Parse(startDateStr.Split('-')[1]);
            int endYear = int.Parse(endDateStr.Split('-')[0]);
            int endMonth = int.Parse(endDateStr.Split('-')[1]);
            int totalMonth = startYear * 12 + startMonth - (endYear * 12 + endMonth);

            Console.WriteLine(totalMonth);
            Console.ReadKey();
        }
    }
}
