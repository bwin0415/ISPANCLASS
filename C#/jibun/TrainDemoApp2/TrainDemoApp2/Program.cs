using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainDemoApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            #region A
            //用條件判斷式-三個數字比大小 小到大或大到小
            Random random = new Random();
            int a, b, c;
            a = random.Next(1,100);
            b = random.Next(1, 100);
            c = random.Next(1, 100);

            if (a==b||b==c||a==c)
            {
                a = random.Next(1, 100);
                b = random.Next(1, 100);
                c = random.Next(1, 100);
            }

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", a, b, c);
                }
                else if (c > b)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", a, c, b);
                }
                else if (b == c)
                {
                    Console.WriteLine("{0}大於{1}等於{2}", a, b, c);
                }
            }
            else if (a == b && a > c)
            {
                Console.WriteLine("{0}等於{1}大於{2}", a, b, c);
            }
            else if (a == c && a > b)
            {
                Console.WriteLine("{0}等於{1}大於{2}", a, c, b);
            }
            else if(b==c&&b>a)
            {
                Console.WriteLine("{0}等於{1}大於{2}", b, c, a);
            }
            else if (a==b&&a==c) 
            {
                Console.WriteLine("{0}等於{1}等於{2}", a, b, c);
            }



            if (b>a&&b>c)
            {
                if (a>c)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", b, a, c);   
                }
                else if (c>a) 
                {
                    Console.WriteLine("{0}大於{1}大於{2}",b,c,a);
                }
                else if (a==c)
                {
                    Console.WriteLine("{0}大於{1}等於{2}", b, c, a);
                }
            }

            if (c>a&&c>b)
            {
                if (a>b)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", c, a, b);   
                }
                else if (b>a) 
                {
                    Console.WriteLine("{0}大於{1}大於{2}",c,b,a);
                }
                else if (b==a) 
                {
                    Console.WriteLine("{0}大於{1}等於{2}",c,b,a);
                }
            }
            #endregion
            #region B
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", a, b, c);
                }
                else if (c > b)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", a, c, b);
                }
            }

            if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", b, a, c);
                }
                else if (c > a)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", b, c, a);
                }
            }

            if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", c, a, b);
                }
                else if (b > a)
                {
                    Console.WriteLine("{0}大於{1}大於{2}", c, b, a);
                }
            }



            #endregion

            Console.ReadKey();
        }

    }
}
