using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 算數運算子 operator
            int x = 9;
            int y = 4;
            int z;
            z = x + y;
            Console.WriteLine("z值為" + z);
            Console.WriteLine("------------------------------------------------");
            z = x - y;
            Console.WriteLine("z值為" + z);
            Console.WriteLine("------------------------------------------------");
            z = x * y;
            Console.WriteLine("z值為" + z);
            Console.WriteLine("------------------------------------------------");
            z = x / y;
            Console.WriteLine("z值為" + z);
            Console.WriteLine("------------------------------------------------");
            z = x % y;
            Console.WriteLine("z值為" + z);
            Console.WriteLine("------------------------------------------------");
            z = -y;
            Console.WriteLine("z值為" + z);
            Console.WriteLine("------------------------------------------------");
            z = x + y * y;
            Console.WriteLine("z值為" + z);
            Console.WriteLine("------------------------------------------------");
            z = (x - y) / y;
            Console.WriteLine("z值為" + z);
            Console.WriteLine("------------------------------------------------");
            int x2 = 5;
            double y2 = 1.6892;
            double z2;
            z2 = x2 * y2;
            Console.WriteLine("z2值為" + z2);
            Console.WriteLine("------------------------------------------------");
            y2 = 1.1234;
            z2 = x2 * y2;
            Console.WriteLine("z2值為" + z2);
            Console.WriteLine("------------------------------------------------");
            #endregion

            #region 指定運算子
            int c = 250;
            int d = 100;
            c += 3;// c = c + 3;
            Console.WriteLine("C值為" + c);
            Console.WriteLine("--------------------------------");
            c -= 3;// c = c - 3;
            Console.WriteLine("C值為" + c);
            Console.WriteLine("--------------------------------");
            c *= 3;// c = c * 3;
            Console.WriteLine("C值為" + c);
            Console.WriteLine("--------------------------------");
            c /= 3;// c = c / 3;
            Console.WriteLine("C值為" + c);
            Console.WriteLine("--------------------------------");
            c %= 3;// c = c % 3;
            Console.WriteLine("C值為" + c);
            Console.WriteLine("--------------------------------");
            c += d;// c = c + d;
            Console.WriteLine("C值為" + c);
            Console.WriteLine("--------------------------------");
            #endregion

            #region 遞增遞減運算子
            int r = 8;
            r++;// r = r + 1
            r--;// r = r - 1
            Console.WriteLine("r值為" + r);
            Console.WriteLine("--------------------------------");
            #endregion

            #region 關係運算子-產生結果為bool布林值
            double m = 85.23;
            double n = 45.23;
            bool compare;

            compare = m == n; //相等
            Console.WriteLine("compare:" + compare);
            Console.WriteLine("--------------------------------");
            compare = m != n; //不相等
            Console.WriteLine("compare:" + compare);
            Console.WriteLine("--------------------------------");
            compare = m >= n;//大於等與
            Console.WriteLine("compare:" + compare);
            Console.WriteLine("--------------------------------");
            compare = m > n;//大於
            Console.WriteLine("compare:" + compare);
            Console.WriteLine("--------------------------------");
            compare = m <= n;//小於等於
            Console.WriteLine("compare:" + compare);
            Console.WriteLine("--------------------------------");
            compare = m < n;//小於
            Console.WriteLine("compare:" + compare);
            Console.WriteLine("--------------------------------");

            #endregion

            #region 複合關係運算子-產生結果為bool布林值
            float p=56.78f;
            float w=92.31f;
            bool logic;

            logic = p < w;
            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------");

            logic = (p < w)&&(p>=50.0f);//And T
            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------");

            logic = (p > 60.0f)&&(p!=w);//And F
            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------");

            logic = (w <= 80.0f)||(p <= w);//or T
            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------");

            logic = (p > w)||(w < 20.0);//or F
            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------");

            logic = (p > 40.0f) && (w < 120.0) && (p==w);//練習 F
            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------");

            logic = (p > 10.0f) || (w > 75.0) || (p>=w);//練習 T
            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------");

            logic = (p > 20.0f) ||(w <50.0) && (p < w);//練習 T
            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------");

            logic = !(w < p);//練習 T
            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------");
            #endregion





            Console.WriteLine("\n任意鍵結束");
            Console.ReadKey();
        }
    }
}
