using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    class Program
    {
        //單行註解
        /*
        多行
        註解
        */
        //藍綠色是類別名稱，黃色是API 方法(物件導向) 涵式(非物件導向) 灰色的是命名空間 白色是屬性
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World !!");
            System.Console.WriteLine("HI,這是一個主控台程式。");
            Console.WriteLine("C#語言示範");
            Console.WriteLine("C# Demo");
            Console.ForegroundColor = ConsoleColor.Yellow;//更改主控台顏色
            Console.BackgroundColor = ConsoleColor.DarkGray;//更改主控台顏色
            Console.WriteLine("1. 主控台應用程式");
            Console.WriteLine("2. Window Form 應用程式");
            Console.WriteLine("3. Web 應用程式");
            Console.WriteLine();
            Console.ResetColor();//重製顏色
            Console.WriteLine("特殊的字元符號");
            Console.WriteLine("\"雙引號\"|");
            Console.WriteLine("\\反斜線\\|");//反斜線可以代表特殊符號
            Console.WriteLine("\'單引號\'|");//單引號代表一個字元
            Console.WriteLine("\t|縮排"); //縮排縮4個字元
            Console.WriteLine("換行\n"); 
            

            Console.WriteLine("按Enter結束程式");
            System.Console.ReadLine();//等待user輸入的一整行
        }
    }
}
