using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承测试
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Obj { Text = "111"};
            var xiaoming = new XiaoMing();
            xiaoming.Speak(obj);
            Console.ReadKey();
        }
    }
}
