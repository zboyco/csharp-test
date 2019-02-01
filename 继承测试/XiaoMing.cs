using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承测试
{
    public class XiaoMing : Man
    {
        public override void Speak(Obj obj)
        {
            Console.WriteLine("小明在说话：" + obj.Text);
            obj.Text = "222";
            base.Speak(obj);
        }
    }
}
