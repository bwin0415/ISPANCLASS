using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{ 
    class Program
    {
        
        static void Main(string[] args)
        {
            #region 整數
            // 變數 Variable 的宣告
            short a = 2000;// = Assign指定 (指定運算子)
            int b = 2500000;
            long c = 4200000000000;
            //無正負號
            ushort aa=65000;
            uint bb = 36000000;
            ulong cc = 121213213132;

            Console.WriteLine("整數宣告");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(aa);
            Console.WriteLine(bb);
            Console.WriteLine(cc);
            
            a = 200;
            b = 999999;
            c = 1178978978978978978;
            aa = 7777;
            bb = 66666;
            cc = 14314130256102561250;
            Console.WriteLine("變更為");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(aa);
            Console.WriteLine(bb);
            Console.WriteLine(cc);
            #endregion

            # region 浮點數
            float f = 3.1415926f;//32位元 精確度到7位小數
            double Db = 3.141592653589793;//64位元 精確度到16位小數
            // decimal 少用 精確到28位小數，128位元 
            Console.WriteLine("\n"+f);
            Console.WriteLine(Db);
            Console.WriteLine("超過16位數，改用整數來運算");
            #endregion

            # region 布林值 
            bool isAttack = true;//1真 開
            bool isJump = false; //0偽 關
            Console.WriteLine("是否攻擊"+isAttack); // + 結合
            Console.WriteLine("是否跳躍"+isJump);   //Console.WriteLine 會自動變成字串結合器
            #endregion

            # region 字串
            //字串是字元加在一起
            string name = "林柏";
            string denwabago = "0912-345-678";
            string email = "test@mmmm.com";
            Console.Write("姓名："+name+" , 電話："+denwabago+" , 電子信箱："+email);
            Console.WriteLine();
            #endregion

            # region 字元  
            char myCharONE = 'ㄟ';
            char myCharTwo = 'x';
            char myCharThird = '黑';
            Console.WriteLine("字元輸出："+myCharONE+myCharTwo+myCharThird);
            #endregion

            # region 字串插入 字串插值
            Console.WriteLine("姓名:{0} 電話:{1} 電子信箱:{2} 年齡：{3}",name,denwabago,email,36);
            #endregion

            # region 變數插入 變數插值
            Console.WriteLine($"姓名:{name} 電話:{denwabago} 電子信箱:{email} 年齡：{36}");
            #endregion

            //Console.WriteLine("\n按Enter結束");
            //Console.ReadLine();
            Console.WriteLine("\n按任意鍵結束");
            Console.ReadKey();


        }
    }
}

