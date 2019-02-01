using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造器测试
{
    public class Class1
    {
        public int Result { get; set; }
        public int Number { get; set; }
        public Class1()
        {
            Result = Number + 100;
        }
    }
}
