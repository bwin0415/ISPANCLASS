using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Person
    {
        public float 身高 = 0.0f;//欄位 
        public double 體重 = 0.0;//欄位 
        public DateTime 到職日 = DateTime.Now;
        public int 部門代號 = 0;

        public string 姓名 { get; set; } //屬性 property get:取值 set 存值    存值=取值 //沒有做設定跟欄位一樣

        protected double _薪資; //protected 只有兒子用的到
        public virtual double 薪資 //屬性
        {
            get
            {//取值
                return _薪資;
            }
            set
            {//存值

                if (value < 25250.0)
                {
                    value = 25250.0;
                }
                else
                {
                    //符合勞基法最低薪資
                }
                _薪資 = value; // value就是屬性值
            }
        }


        //泛型欄位 Generics
        public PersonInfo<string> Email = new PersonInfo<string>();
        public PersonInfo<int> 年齡 = new PersonInfo<int>();

        //結構欄位 struct
        public AddressInfo 地址;


        public Person()
        {
            //預設建構式--它本身就是一個資料型態
            //每個類別都要有建構式，沒建建構式但可以跑得原因是因為C#會自動幫你家。
            //特點1.不宣告資料型態 2.一定不能是private
        }

        public Person(string myName)
        {
           //建構方法多載
          this.姓名 = myName; //在C#裡面this可省略  this就是物件本身
        }
        public virtual void 顯示基本資料功能()
        {//virtual 允許被複寫
            //string strInfo = $"姓名：{this.姓名} 身高:{this.身高} 體重：{this.體重}  到職日：{this.到職日} 薪資: {this.薪資}";
            string strInfo = string.Format("姓名：{0}\n身高：{1:F2}\n體重：{2:F2}\n到職日：{3:d}\n薪資：{4:C}\n部門代號：{5}\n部門名稱:{6}年齡：{7}\nEmail：{8}\n地址：{9}", 姓名,身高,體重,到職日,薪資,部門代號,顯示部門名稱(部門代號),年齡.data, Email.data,地址.完整地址());
            strInfo += "本資料由" + GlobalVar.目前使用者 + "編輯輸入";
            MessageBox.Show(strInfo);
        }
        public static void aboutInfo() //靜態方法不需實體化
        {
            MessageBox.Show("類別名稱：Person \n 功能：儲存員工基本資料\n版本：v0.1");
        } 
        public double 計算年資()
        {
            double 年資 = 0.0;

            TimeSpan ts = DateTime.Now - this.到職日;
            年資 = ts.TotalDays / 365.0; 
            return 年資;
        }
        public double 依年資計算獎金(double 一年資獎金) 
        {
            //最低獎金500
            double 獎金 = 0.0;
            獎金 = 一年資獎金 * 計算年資();
            if (獎金<500)
            {
                獎金 = 500;
            }
     



            return 獎金;

        }

        public virtual string 顯示部門名稱(int 部門代號) 
        {
            string strDep="";

            switch (部門代號)
            {
                case (int)MyEnums.Dep.行政處:
                    strDep = "行政執行處";
                    break;
                case (int)MyEnums.Dep.資訊處:
                    strDep = "資訊管理處";
                    break;
                case (int)MyEnums.Dep.業務部:
                    strDep = "業績推管部";
                    break;
                case (int)MyEnums.Dep.研發部:
                    strDep = "創新研發部";
                    break;
                default:
                    strDep = "無此部門";
                    break;
            }

            return strDep;
        }
     }

}
