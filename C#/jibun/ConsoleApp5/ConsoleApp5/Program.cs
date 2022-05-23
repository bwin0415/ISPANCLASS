using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            #region 迴圈loop
            for (int i = 0; i <= 20; i += 1)//步進值
            {
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("--------------------------------");
            for (int i = 2;  i <= 100; i += 2)//偶數 2...100
            {
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("--------------------------------");
            for (int i = 10;  i >= 1; i -= 1)//10...1
            {
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("--------------------------------");
            for (int i = 0;  i <= 20; i += 1)//到9中斷 break
            {
                if (i>9)
                {
                    break;
                }
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("--------------------------------");
            for (int i = 0;  i <= 20; i += 1)//到9跳過 continue
            {
                if (i==8)
                {
                    continue;
                }
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("--------------------------------");

            #endregion

            #region 雙迴圈  內層的迴圈先跑完再跑外層的迴圈
            for (int i = 0; i < 5; i+=1)//row y軸
            {
                for (int j = 5; j <=10; j+=1)//column x軸
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("====================");
            for (int i = 1; i <= 10; i+=1)//row y軸
            {
                for (int j = 1; j <=i; j+=1)//column x軸
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(" {0}乘{1}等於{2} ",i,j,i*j) ;
                }
                Console.WriteLine();
            }

            #endregion
            //輸出等腰三角形 ,菱形
            //課程作業加分題 請輸出 聖誕樹 彩色有裝飾




            Console.WriteLine("========================================");
            Console.WriteLine("任意鍵結束");
            Console.ReadKey();
        }
    }
}
/*   
 *   
    /\
   / *\
  / *  \
   / *\
  / * *\
 /*  * *\
/  *  *  \
   |  |
   |__|

*/