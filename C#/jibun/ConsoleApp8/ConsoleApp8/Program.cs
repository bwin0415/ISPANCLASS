using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array( 一、) 陣列 視為 物件 (object)
            int[] arrayOne = new int[6]; //只要是物件 初始化都要用 new
            arrayOne[0] = 1;
            arrayOne[1] = 2;
            arrayOne[2] = 3;
            arrayOne[3] = 4;
            arrayOne[4] = 5;
            arrayOne[5] = 6;

            for (int i = 0; i <=5; i++)
            {
                Console.WriteLine("arrayOne取出索引值為{0}的元素內容{1}", i, arrayOne[i]);
            }
            Console.WriteLine("------------------");
            arrayOne[4] = 88;
            for (int i = 0; i <=5; i++)
            {
                Console.WriteLine("arrayOne取出索引值為{0}的元素內容{1}", i, arrayOne[i]);
            }

            #endregion

            #region Array( 二、 ) 不能超過索引值範圍
            Console.WriteLine("-------------------------------");
            
            int[] array2 = new int[] { 6, 5, 4, 3, 2, 1 };
            int[] array3 =  { 7, 8, 9, 10, 17,11 };//簡寫法
            Console.WriteLine("array3取出索引值為4的元素內容{0}", array3[4]);
            Console.WriteLine("-------------------------------");

            string[] array科目名稱 = { "國文", "英文", "數學", "自然","社會" };
            Console.WriteLine("array科目名稱:[{0}] ={1} ",2, array科目名稱[2]);
            Console.WriteLine("-------------------------------");

            for (int i = 0; i <array科目名稱.Length; i+=1)
            {
                Console.WriteLine("array科目名稱:[{0}] ={1} ", i, array科目名稱[i]);
            }

            #endregion
            #region foreach
            Console.WriteLine("------------------");
            foreach (string subject in array科目名稱)
            {
                Console.WriteLine(subject);

            }
            Console.WriteLine("------------------");
            #endregion
            #region 2維陣列 , Tow Dimesion Array,Dim
            int[,] array2D_One = new int[4,2];
            array2D_One[0, 0] = 8;
            array2D_One[0, 1] = 7;
            array2D_One[1, 0] = 6;
            array2D_One[1, 1] = 5;
            array2D_One[2, 0] = 4;
            array2D_One[2, 1] = 3;
            array2D_One[3, 0] = 2;
            array2D_One[3, 1] = 1;
            int[,] array2D_Two = { { 8, 7 }, { 6, 5 }, { 4, 3 }, { 2, 1 } };
            for (int i = 0; i <=array2D_One.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array2D_One.GetUpperBound(1); j++)
                {
                    Console.WriteLine("array2D_TOW[{0},{1}] = {2}",i,j,array2D_Two[i,j]);
                }

            }
            #endregion

            #region 3維陣列 
            int[,,] array3D_One =new int[2,3,4] 
            {
                {
                    {1,2,3,4 },
                    {5,6,7,8 },
                    {9,10,11,12 } 
                },
                {
                    {13,14,15,16 },
                    {17,18,19,20 },
                    {21,22,23,24 } 
                } 
            };
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i <=array3D_One.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array3D_One.GetUpperBound(1); j++)
                {
                    for (int k = 0; k<=array3D_One.GetUpperBound(2); k++)
                    {
                        Console.WriteLine("array3D_One[{0},{1},{2}] = {3}", i, j,k, array3D_One[i, j,k]);
                    }   
                }
            }
            #endregion

            #region 練習
            Console.WriteLine("===============================");
            Console.WriteLine("= 請 輸 入 搜 尋 科 目 名 稱  =");
            Console.WriteLine("= 輸 入 完 成 請 案 ENTER    =");
            Console.WriteLine("===============================");
            string str搜尋科目 = Console.ReadLine();
            bool is有這科目 = false;

            for (int k = 0; k < array科目名稱.GetUpperBound(0); k++)
            {
                if (array科目名稱[k] == str搜尋科目)
                {
                    Console.WriteLine("有此科目： " + array科目名稱[k] + " index:" + k);
                    is有這科目 = true;
                    break;
                }
            }
            if (is有這科目 == false)
            {
                Console.WriteLine("找不到該科目");
            }
            #endregion









            Console.WriteLine("------------------");
            
            
            Console.ReadKey();
        }
    }
}
