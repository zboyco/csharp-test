using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Program
    {
        static void Main(string[] args)
        {
            Test<string>(ActionString, "Hello World!");
            Test<int>(ActionInt, 1000);
            Test<string>(p => { Console.WriteLine("{0}", p); }, "Hello World");//使用Lambda表达式定义委托
            Console.ReadKey();
        }
        public static void Test<T>(Action<T> action, T p)
        {
            action(p);
        }
        private static void ActionString(string s)
        {
            Console.WriteLine(s);
        }
        private static void ActionInt(int s)
        {
            Console.WriteLine(s);
        }
    }
}
