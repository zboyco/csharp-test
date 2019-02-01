using System;

namespace 获取零点时刻非0情况下的DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string param = "15:00:00";
            TimeSpan span = TimeSpan.Parse(param);
            int result = (int)DateTime.Now.Add(-span).DayOfWeek;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
