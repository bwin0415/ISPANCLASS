using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainDemoApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 樹
            for (int i = 1; i <= 10; i +=2)//row y軸
            {
                
                for (int j = 1; j <=i; j += 2)//column x軸
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 1; i <= 10; i +=2)//row y軸
            {
                for (int j = 1; j <=i; j += 2)//column x軸
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 1; i <= 10; i +=2)//row y軸
            {
                for (int j = 1; j <=i; j += 2)//column x軸
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 1; i <=6 ; i +=1)//row y軸
            {
                for (int j = 1; j <=4; j += 2)//column x軸
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            #endregion
            #region 菱形
            Console.WriteLine("=========================================");
            for (int i =0 ; i < 6 ; i += 1)
            {
                for (int j =0 ; j <6-i; j += 1)//column x軸
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <i*2+1; j += 1)//column x軸
                {
                    Console.Write("*");
                   
                    
                }
                Console.WriteLine();

            }
            
           for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <i+2; j += 1)//column x軸
                {
                    Console.Write(" ",j);
                }
                for (int j = 0; j < (5 - i) * 2 - 1; j += 1)//column x軸
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
            #endregion
            #region 三角形
            Console.WriteLine("========================================");
            for (int i =0 ; i <5; i += 1)//row y軸
            {
                for (int j = 0; j <6 - i; j += 1)//column x軸
                {
                    Console.Write("",j);
                }
                for (int j = 0; j <i*2+1 ; j += 1)//column x軸
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine("========================================");
            #region 聖誕樹
            for (int i = 0; i < 5; i += 1)//row y軸
            {
                for (int j = 0; j < 6 - i; j += 1)//column x軸
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 + 1; j += 1)//column x軸
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    }
                    else if(i%2==1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (j % 2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    
                     Console.Write("*");
                }


                Console.WriteLine();

            }            
            for (int i = 0; i <=5; i += 1)//row y軸
            {
                for (int j = 0; j <=5 - i-1; j += 1)//column x軸
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i * 2+2 ; j += 1)//column x軸
                {
                    if(j%3==1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    else if (j % 3 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    
                     Console.Write("*");
                }


                Console.WriteLine();

            }
            for (int i = 0; i <= 5; i += 1)//row y軸
            {
                for (int j = 0; j <= 5 - i-1; j += 1)//column x軸
                {
                    Console.Write("0");
                }
                for (int j = 0; j <= i *2+2; j += 1)//column x軸
                {
                    if (i % 2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if(j%2 ==1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }

                    Console.Write("*");
                }


                Console.WriteLine();

            }
            for (int i = 0; i <5 ; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" ");
                } 
                for (int j = 0; j < 5; j++)
                {
                 Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.ResetColor();


            #endregion

            for (int i = 0; i < 5; i += 1)//row y軸
            {
                for (int j = 0; j < (8 - i)-1; j += 1)//column x軸
                {
                    Console.Write(" ", j);
                }
                for (int j = 0; j < i * 2 + 1; j += 1)//column x軸
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i += 1)//row y軸
            {
                for (int j = 0; j < (7 - i)-1; j += 1)//column x軸
                {
                    Console.Write(" ", j);
                }
                for (int j = 0; j < i * 2 + 3; j += 1)//column x軸
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 7; i += 1)//row y軸
            {
                for (int j = 0; j < (7 - i)-1; j += 1)//column x軸
                {
                    Console.Write(" ", j);
                }
                for (int j = 0; j < i * 2 + 3; j += 1)//column x軸
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 5; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("|");
                }
                Console.WriteLine();
            }

            Console.ResetColor();

            Console.WriteLine("========================================");

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i*2+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <=i ; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 5; j >i*2-4 ; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }





            Console.WriteLine("========================================");
            Console.WriteLine("任意鍵結束");
            Console.ReadKey();
        }
    }
}
