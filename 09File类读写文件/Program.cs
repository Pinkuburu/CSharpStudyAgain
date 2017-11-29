using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09File类读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadAllText
            //string[]str= File.ReadAllLines(@"D:\Alex\Desktop\代码学习用的测试文本.txt", Encoding.Default);
            //for (int i = 0; i < str.Length; i++)
            //{                
            //    Console.WriteLine(str[i]);
            //}

            ////把文件读取为字节数组
            //byte[] txtbyte= File.ReadAllBytes(@"D:\Alex\Desktop\代码学习用的测试文本.txt");
            ////把字节数组解码，这下面的default是编码方式
            //string strbyte=Encoding.Default.GetString(txtbyte);
            //Console.WriteLine(strbyte);

            //File.WriteAllLines(@"D:\Alex\Desktop\代码学习用的测试文本2.txt", new string[] { "a", "b", "c" });//每写一个换一行,如果再执行一次就会覆盖源文件

            //File.WriteAllText(@"D:\Alex\Desktop\代码学习用的测试文本3.txt","abc");//如果再执行一次就会覆盖源文件

            //string str4 = "少女前线天下第一";
            ////把字符串转换成字节数组
            //byte[] str4buffer= Encoding.Default.GetBytes(str4);
            //File.WriteAllBytes(@"D:\Alex\Desktop\代码学习用的测试文本4.txt", str4buffer);//如果再执行一次就会覆盖源文件

            File.AppendAllText(@"D:\Alex\Desktop\代码学习用的测试文本4.txt","少女前线真好玩啊",Encoding.Default);//往文件追加
            Console.WriteLine("操作完成");
            Console.ReadKey();
        }
    }
}
