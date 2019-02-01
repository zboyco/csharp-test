using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承测试
{
    public abstract class Man : Person
    {
        public override void Speak(Obj obj)
        {
            Console.WriteLine("人在说话：" + obj.Text);
        }
    }
}
