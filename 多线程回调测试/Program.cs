using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程回调测试
{
    public class TestClass
    {
        //声明一个delegate（委托）类型：TestDelegate，该类型可以搭载返回值为空，参数只有一个(long型)的方法。 
        public delegate void TestDelegate(long i);

        //声明一个TestDelegate类型的对象。该对象代表了返回值为空，参数只有一个(long型)的方法。它可以搭载N个方法。 
        public TestDelegate mainThread;

        /// 测试方法 
        /// <summary>          
        /// </summary> 
        public void TestFunction()
        {
            long i = 0;
            while (true)
            {
                i++;
                Console.WriteLine(i);
                //mainThread(i); //调用委托对象 
                Thread.Sleep(1000);  //线程等待1000毫秒 
            }
        }
    }

    class testHelper
    {
        public testHelper()
        {
            //创建TestClass类的对象 
            TestClass testClass = new TestClass();

            //在testclass对象的mainThread(委托)对象上搭载两个方法，在线程中调用mainThread对象时相当于调用了这两个方法。 
            testClass.mainThread = new TestClass.TestDelegate(RefreshLabMessage1);
            //testClass.mainThread += new TestClass.TestDelegate(RefreshLabMessage2);

            //创建一个无参数的线程,这个线程执行TestClass类中的TestFunction方法。 
            Thread testClassThread = new Thread(new ThreadStart(testClass.TestFunction));
            //启动线程，启动之后线程才开始执行 
            testClassThread.Start();
        }

        /// <summary> 
        /// 在界面上更新线程执行次数 
        /// </summary> 
        /// <param name="i"></param> 
        private void RefreshLabMessage1(long i)
        {
            Console.WriteLine(i);
        }


        /// <summary> 
        /// 在界面上更新线程执行次数 
        /// </summary> 
        /// <param name="i"></param> 
        //private void RefreshLabMessage2(long i)
        //{
        //    //同上 
        //    if (this.labMessage2.InvokeRequired)
        //    {
        //        //再次创建一个TestClass类的对象 
        //        TestClass testclass = new TestClass();
        //        //为新对象的mainThread对象搭载方法 
        //        testclass.mainThread = new TestClass.TestDelegate(RefreshLabMessage2);
        //        //this指窗体，在这调用窗体的Invoke方法，也就是用窗体的创建线程来执行mainThread对象委托的方法，再加上需要的参数(i) 
        //        this.Invoke(testclass.mainThread, new object[] { i });
        //    }
        //    else
        //    {
        //        labMessage2.Text = i.ToString();
        //    }
        //}
    }

    class Program
    {
        public static void Main()
        {
            var test = new testHelper();
            Console.Read();
        }
    }

}
