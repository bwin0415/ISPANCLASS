using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            #region while實作
            while (true)
            {
                Console.Clear();

                Console.WriteLine("================================================)");
                Console.WriteLine("==========      超 好 吃 下 午 茶    ===========)");
                Console.WriteLine("================================================)");
                Console.WriteLine("甜點選擇：(代號 a: 布丁,b:冰淇淋,c:奶酪,d:紅豆湯)");
                Console.WriteLine("結束請輸入X");
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
                if (ss=="x")
                {
                    break;
                }
                Console.WriteLine("=========================================");
                Console.WriteLine("按下任意鍵退出");
                Console.ReadKey();
            }
            #endregion




        }
    }
}
