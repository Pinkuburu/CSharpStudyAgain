using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06params可变参数数组学习
{
    class Program
    {
        #region 常规的写数组方法的这种写法
        //static void Main(string[] args)
        //{
        //    int[] s = { 98, 56, 56 };
        //    GetScore("张三", s);
        //    Console.ReadKey();
        //}

        //public static void GetScore(string name, int[] score)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < score.Length; i++)
        //    {
        //        sum += score[i];
        //    }
        //    Console.WriteLine("{0}的总成绩是{1}", name, sum);
        //}
        #endregion

        #region 采用了可变数组params的写法
        static void Main(string[] args)
        {
            //int[] s = { 98, 56, 56 };
            GetScore("张三", 98, 56, 56,5464,8,23,5,3,4);
            Console.ReadKey();
        }

        public static void GetScore(string name,params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}的总成绩是{1}", name, sum);
        }
        #endregion
    }
}
