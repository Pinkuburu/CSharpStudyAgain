using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 课程上到飞行棋的输入玩家名字
/// </summary>
namespace _08飞行棋游戏
{
    class Program
    {
        public static int[] Maps = new int[100];//储存地图的数组
        public static int[] Playerpos = new int[2];//0是A的坐标，1是B的坐标

        static void Main(string[] args)
        {
            GameHead();
            InitialMap();
            DrawMap();
            Console.ReadKey();
        }

        /// <summary>
        /// 游戏头
        /// </summary>
        public static void GameHead()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********飞行棋游戏*************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**********************************");
        }

        public static void InitialMap()
        {
            //用0表示普通地图，显示为♢
            //1表示幸运轮盘，显示为●
            //2表示地雷，显示★
            //3表示暂停，显示为▲
            //4表示隧道，显示为卐
            int[] luck = { 6, 43, 12, 55, 69, 83 };
            for (int i = 0; i < luck.Length; i++)
            {
                Maps[luck[i]] = 1;
            }

            int[] landmine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            for (int i = 0; i < landmine.Length; i++)
            {
                Maps[landmine[i]] = 2;
            }

            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }

            int[] tunnel = { 20, 25, 45, 63, 72, 88, 90 };
            for (int i = 0; i < tunnel.Length; i++)
            {
                Maps[tunnel[i]] = 4;
            }
        }

        public static void DrawMap()
        {
            #region 第一横行
            for (int i = 0; i <= 29; i++)
            {
                Console.Write(DrawStringMap(i));
            }//for
            #endregion
            //画完第一横行后应该换行
            Console.WriteLine();

            #region 第一竖行
            for (int i = 30; i <= 34; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion

            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();

            #region 第二竖行
            for (int i = 65; i <= 69; i++)
            {
                
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion

            #region 第三横行
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();
        }
        /// <summary>
        /// 抽象出来画地图的方法 返回一个要画的字符串
        /// </summary>
        /// <param name="i">当前地图坐标</param>
        /// <returns></returns>
        public static string DrawStringMap(int i)
        {
            string str = "";
            if (Playerpos[0] == Playerpos[1] && Playerpos[1] == i)
            {
                str = "<>";
            }
            else if (Playerpos[0] == i)
            {
                str = "A";
            }
            else if (Playerpos[1] == i)
            {
                str = "B";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        str = "卐";
                        break;
                }//switch

            }//else
            return str;
        }
    }
}
