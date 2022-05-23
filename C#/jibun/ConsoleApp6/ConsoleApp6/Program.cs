using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while迴圈  先判斷後執行

            while (true)
            {
                Console.WriteLine("Hello World.");
                break;
            }
            Console.WriteLine("-------------------------------------");            
            int d = 1;
            while (true)            {
                if (d>10)
                {
                    break;
                }
                Console.WriteLine("d:" + d);
                d++;
            }
            Console.WriteLine("-------------------------------------");
            int dd = 1;
            while (dd<=10)
            {
                Console.WriteLine("dd:" + dd);
                dd ++ ;
            }
            Console.WriteLine("-------------------------------------");
            #endregion

            #region do...while迴圈 先執行後判斷 至少會跑一次
            do
            {
                Console.WriteLine("Hello World.");
            }
            while (false);
            Console.WriteLine("-------------------------------------");
            int g = 1;
            do
            {
                Console.WriteLine("g:"+g);
                g += 1;
            }
            while (g<=10);
            #endregion



            Console.WriteLine("-------------------------------------");

            Console.WriteLine("========================================");
            Console.WriteLine("任意鍵結束");
            Console.ReadKey();
        }
    }
}
