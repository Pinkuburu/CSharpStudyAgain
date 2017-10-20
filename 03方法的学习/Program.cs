using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03方法的学习
{
    class Program
    {

        public static int _a = 3;//静态字段，当作“全局变量”使用，在类中所有的函数可使用


        //我们在Main函数中调用test函数，我们管main叫调用者，test叫被调用者
        //如果被调用者想要得到调用者里的值
        //1、传递参数，如下
        //2、声明一个静态字段，当作“全局变量”使用

        #region 传递参数
        static void Main(string[] args)
        {
            int a = 3;//有效范围只有main函数中
            int anew=Test(a);//这是一个实参
            Console.WriteLine(anew);
            Console.ReadKey();
        }
        public static int Test(int a)//方法中的这个值是形参，也会在内存中开辟空间
        {
            a = a + 5;
            return a;//如果调用者想要得到被调用者的值，需要用return
        }
        #endregion

        #region  静态字段当“全局变量”

        #endregion


    }
}
