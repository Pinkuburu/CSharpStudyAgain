using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04out的学习
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            char y;
            string s = Test(out n, out y);//s接受的是return的东西，其他的需要用其他变量来接受
            Console.WriteLine(n);
            Console.WriteLine(s);
            Console.WriteLine(y);
            Console.ReadKey();
        }

        public static string Test(out int number, out char yige)//out可以多个参数
        {
            number = 100;
            yige = 'a';
            return "张三";
        }
    }
}
