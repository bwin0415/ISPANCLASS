using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WelcomeMessage();
        }




        private void btn_無參數_Click(object sender, EventArgs e)
        {
            int mySum = Sum();
            MessageBox.Show("1到5的總和"+mySum);
        }



        private void btn_有參數_Click(object sender, EventArgs e)
        {
            BasicString("Tom","Apple Watch",12800.0,5);
            //參數 parameters == 引數 arguments
        }

        private void btn_回傳值_Click(object sender, EventArgs e)
        {
           int mySum = Sum(5,4,3,2,1);
            MessageBox.Show("5到1的總和" + mySum);
        }


        #region 自訂方法

        void WelcomeMessage()//void =>方法(涵式)關鍵字 void =>沒有回傳值 沒有參數
        {
            MessageBox.Show("歡迎使用本程式");
        }

        int Sum() //return 就是右邊是回傳值的內容 方法碰到return就會停止執行方法 
        {
            int sum = 0;
            sum = 1 + 2 + 3 + 4 + 5;
            return sum;
        }

        void BasicString(string name,string product,double price, int amount) 
        {
            string output = string.Format($"{name} 購買 {product} 一共 {amount} 件 總價 {price*amount} 元");
            MessageBox.Show(output);
        }
        




        int Sum(int a,int b, int c, int d, int e)
        {
            int sum = a + b + c + d + e;
            return sum;
        }

        #endregion


    }
}
