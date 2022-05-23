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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("第一個Windows Form程式");//Debug的內容
            Console.WriteLine("小數位數的控制 pi: {0}", 3.141592);
            Console.WriteLine("小數位數的控制 pi: {0:F4}", 3.141592);//索引值 + : + 格式化字元 F=> 設定小數進位 支援4捨5入
            Console.WriteLine("百分比號的控制 百分比： {0:P}", 0.8765);//索引值 + : + 格式化字元 P=> 設定百分比號
            Console.WriteLine("科學記號的控制 科學記號： {0:E}", 0.00000000000015007);//索引值 + : + 格式化字元 E => 科學記號
            Console.WriteLine("科學記號的控制 科學記號： {0:E}", 12345000000000000.0);//索引值 + : + 格式化字元 E => 科學記號
            Console.WriteLine("金融符號的控制 金融符號： {0:C}", 123450000000);//索引值 + : + 格式化字元 C => 金融符號
            Console.WriteLine("整數補0的控制 整數補0： {0:D8}", 12345);//索引值 + : + 格式化字元 D數字<=第幾位//=> 整數補0

            Console.WriteLine("現在時間：{0}",System.DateTime.Now);//時間
            Console.WriteLine("{0:d}", DateTime.Now);//索引值 +  : + d 簡化日期
            Console.WriteLine("{0:D}", DateTime.Now);//索引值 +  : + D 中文日期
            Console.WriteLine("{0:F}", DateTime.Now);//索引值 +  : + F 中文日期+時間
            Console.WriteLine("{0:T}", DateTime.Now);//索引值 +  : + T 時間
            Console.WriteLine("{0:t}", DateTime.Now);//索引值 +  : + t 時間不含秒 
            Console.WriteLine("{0:M}", DateTime.Now);//索引值 +  : + M 只有月份

            //同名的方法不同的功能稱為多載
            System.Windows.Forms.MessageBox.Show("歡迎使用本程式");
            MessageBox.Show("Windows Form app 開發","標題",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            lblmain.Text = "Super好喝冷飲自動販賣機";
            lblmessage.Text = "請選擇購買的飲料";
        }

        private void btntea_Click(object sender, EventArgs e)
        {
            lblmessage.Text =" 您選擇了紅茶，請投入20元 ";
        }

        private void btngreentea_Click(object sender, EventArgs e)
        {
            lblmessage.Text = " 您選擇了綠茶，請投入20元 ";
        }

        private void btnmilk_Click(object sender, EventArgs e)
        {
            lblmessage.Text = " 您選擇了奶茶，請投入40元 ";
        }

        private void btn_happywater_Click(object sender, EventArgs e)
        {
            lblmessage.Text = " 您選擇了快樂水，請投入1000元 ";
        }
    }





































}
