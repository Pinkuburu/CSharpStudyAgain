using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02冒泡排序练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {10,9,8,7,6,5,4,3,2,1,0 };
            for (int i = 0; i < nums.Length-1; i++)//控制比较的趟数
            {
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    if (nums[j]>nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;

                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }
    }
}
