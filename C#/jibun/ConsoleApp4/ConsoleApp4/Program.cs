using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 200;
            int y = 200;

            #region 條件判斷式(1) if...else... if結果一定要true才會執行 else則是false
            if (x > y)
            {//true
                Console.WriteLine("x 大於 y");
            }
            else
            {//false
                Console.WriteLine("x 小於等於 y");
            }
            Console.WriteLine("---------------------------------------------");
            #endregion

            #region 條件判斷式(2)
            if (x > y)
            {
                Console.WriteLine("x 大於 y");
            }
            else
            {
                if (x == y)
                {
                    Console.WriteLine("x 等於 y");
                }
                else
                {
                    Console.WriteLine("x 小於 y");
                }
            }
            Console.WriteLine("---------------------------------------------");
            #endregion

            #region 條件判斷式(3)
            if (x > y)
            {
                Console.WriteLine("x 大於 y");
            }
            else if (x == y)
            {
                Console.WriteLine("x 等於 y");
            }
            else if (x < y)
            {
                Console.WriteLine("x 小於 y");
            }
            else
            {
                Console.WriteLine("Error");
            }
            
            Console.WriteLine("---------------------------------------------");
            #endregion

            #region 條件判斷式(4) if...else... 簡式 指定情況下才能用
            int w = - 2;
            int s = 6;
            if (w<0)
            {
                s = -1;
            }else
            {
                s = w * 2;
            }
            Console.WriteLine("s:" + s);
            s = (w < 0) ? -1 : (w * 2);// 問號?左邊是條件 右邊是結果 冒號:左邊是true 右邊是false
            Console.WriteLine("簡式 s:" + s);
            Console.WriteLine("--------------------------------------------------" );
            #endregion

            #region 條件判斷式(5) switch.....case.....
            Console.WriteLine("=============================");
            Console.WriteLine("甜點選擇：(代號 a: 布丁,b:冰淇淋,c:奶酪,d:紅豆湯)");
            Console.WriteLine("輸入代號完成請按Enter");
            string ss = Console.ReadLine();

            switch (ss)
            {
                case "a":
                    Console.WriteLine("您選了布丁 60元");
                    break;
                case "b":
                    Console.WriteLine("您選了冰淇淋 80元");
                    break;
                case "c":
                    Console.WriteLine("您選了奶酪 100元");
                    break;
                case "d":
                    Console.WriteLine("您選了紅豆湯 70元");
                    break;
                default:
                    Console.WriteLine("無此產品");
                    break;
            }
            #endregion

            Console.WriteLine("按下任意鍵退出");
            Console.ReadKey();
        }
    }
}
