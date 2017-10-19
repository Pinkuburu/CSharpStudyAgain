using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01数组练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 99乘法表
            //for (int i = 1; i <= 9; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i+"*"+j+"="+ i * j+ "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region 计算一个int数组里的最大最小总和平均
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = nums[0];
            //int min = nums[0];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]>max)
            //    {
            //        max = nums[i];
            //    }
            //    if (nums[i]<min)
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];
            //}
            //Console.WriteLine("这个数组中最大的数字是{0},最小数字是{1}，总和是{2}，平均值是{3}",max,min,sum,sum/nums.Length);
            //Console.ReadKey();
            #endregion

            #region 把文字数组每一个文字后面加一个竖线
            //string[] names = { "aa", "bb", "cc", "dd", "ee", "ff" };
            //string str = null;
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    str += names[i] + "|";

            //}
            //Console.WriteLine(str+names[names.Length - 1]);//这句话的意思是str的值，加name数组的长度-1的内容
            //Console.ReadKey();
            #endregion

            #region 把数组中的东西头尾两两交换
            //string[] names = { "a", "b", "c", "d", "e" };

            //for (int i = 0; i < names.Length/2; i++)
            //{
            //    string temp = names[i];
            //    names[i] = names[names.Length - 1 - i];
            //    names[names.Length - 1 - i] = temp;

            //}

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            ////Console.WriteLine(names); 数组输出元素，必须遍历循环数组内容打印出来
            //Console.ReadKey();
            #endregion
        }
    }
}
