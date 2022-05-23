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
    class Manager : Person ,IMan  //C#單一繼承
    {
        public int 職稱代號 = 0;
        public Manager() 
        {
            //建構式不繼承
        }
        public Manager(string myName)
        {
            姓名 = myName + "主管";
        }
        public override double 薪資 //屬性
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
                value += 6000;//管理加給
                _薪資 = value; // value就是屬性值
            }
        }
        public override void 顯示基本資料功能()
        {   //override 資料複寫
            //string strInfo = $"姓名：{this.姓名} 身高:{this.身高} 體重：{this.體重}  到職日：{this.到職日} 薪資: {this.薪資}";
            string strInfo = string.Format("姓名：{0}\n身高：{1:F2}\n體重：{2:F2}\n到職日：{3:d}\n薪資：{4:C}\n職稱：{5}\n部門名稱：{6}\n年齡：{7}\nEmail：{8}\n地址：{9}", 姓名, 身高, 體重, 到職日, 薪資,顯示職稱(職稱代號),顯示部門名稱(部門代號),年齡.data,Email.data, 地址.完整地址());
            strInfo += "管理者職務";
            MessageBox.Show(strInfo);
        }

        public string 顯示職稱(int 職稱代號) 
        {
            string strMan = "";

            switch (職稱代號)
            {
                case (int)MyEnums.Man.董事長:
                    strMan = "董事長";
                    break;
                case (int)MyEnums.Man.總經理:
                    strMan = "總經理";
                    break;
                case (int)MyEnums.Man.副總:
                    strMan = "副總";
                    break;
                case (int)MyEnums.Man.經理:
                    strMan = "經理";
                    break;
                case (int)MyEnums.Man.組長:
                    strMan = "組長";
                    break;
                default:
                    strMan = "無此職稱";
                    break;
            }
            return strMan;
        }
    }
}
