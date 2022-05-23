using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainDemoApp4
{
    //練習便當選單 是否有無銷售 有的話輸出 價錢 
    //建立2維 string 陣列, 便當名稱 跟價格,做搜尋
    // string[,] bandon： 10種便當{  }{  }{  }{  }{  }{  }{  }{  }{  }{  }{  }
    class Program
    {
        static void Main(string[] args)
        {
            string[,] bandon = 
                {

                          {"魚排便當","90元",},
                          {"招牌便當","85元",},
                          {"排骨便當","80元",},
                          {"雙拼A便當","95元",},
                          {"雙拼B便當","100元"},
                          {"三杯雞便當","80元"},
                          {"滷雞腿便當","80元"},
                          {"燒雞腿便當","95元"},
                          {"酥炸雞腿便當","95元"},
                          {"宮保雞丁便當","80元"},
                 };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("=|                                                                          |=");
                Console.WriteLine("=|                                很 有 事 便 當                            |=");
                Console.WriteLine("=|                                                                          |=");
                Console.WriteLine("==============================================================================");
                Console.WriteLine("=|                                                                          |=");
                Console.WriteLine("=|                               今 天 想 來 點 ？                          |=");
                Console.WriteLine("=|                                                                          |=");
                Console.WriteLine("==============================================================================");
                Console.WriteLine();

                for (int i = 0; i < bandon.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        if (i < bandon.GetUpperBound(0))
                        {
                            Console.Write("                                 ");
                        }
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        if (i < bandon.GetUpperBound(0))
                        {
                            Console.Write("{0}\n", bandon[i, 0]);
                        }
                    }


                    Console.WriteLine();

                        
                }
                
                Console.WriteLine("==============================================================================");
                Console.WriteLine("=|                        請 輸 入 您 要 的 餐 點 名 稱                     |=");
                Console.WriteLine("==============================================================================");
               
                string ss = Console.ReadLine();
                Console.WriteLine("==============================================================================");

                for (int i = 0; i < bandon.GetUpperBound(0); i++)
                {


                    if (ss == bandon[i, 0])
                    {
                        Console.WriteLine("一份{0}，{1}", bandon[i, 0], bandon[i, 1]);
                        Console.WriteLine("                                 還需要甚麼嗎?");
                        Console.WriteLine("==============================================================================");
                        break;
                    }
                    else if (ss=="")
                    {
                        Console.WriteLine("                                 抱歉，不了解您的需求");
                        break;
                    } 
                    else if (ss!= bandon[i, 0]&& ss != "esc")
                    {
                        Console.WriteLine("                                 抱歉，本店無販賣此產品");
                        break;
                    }
                    


                }
                Console.ReadKey();


            }




            //Console.WriteLine("一份{0}，{1}", bandon[i, 0], bandon[i, 1]);
            
        }
    }
}
