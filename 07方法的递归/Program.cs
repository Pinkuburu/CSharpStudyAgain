using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的递归，在方法内部自己调用自己
            //找一个文件夹下的所有文件
            TellStory();
            Console.ReadKey();
        }
        public static int i = 0;//为了不受循环里的数字影响，声明一个static变量
        public static void TellStory()
        {
            i++;
            Console.WriteLine("从前有个人讲了个故事，故事是这样的");
            Console.WriteLine("这个人说道");
            if (i>=5)
            {
                return;//这一步跳出之后，他要return跳出几次，因为是一层层的套进去，出来也要一层层的出来
            }
            TellStory();
        }
    }
}
