using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承测试
{
    public abstract class Person
    {
        public string Name { get; set; }
        public abstract void Speak(Obj obj);
    }
}
