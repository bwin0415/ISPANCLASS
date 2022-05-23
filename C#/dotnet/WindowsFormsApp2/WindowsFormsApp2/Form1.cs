using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public delegate void MyDelegate(string msg);





        public Form1()
        {
            InitializeComponent();
        }
        //Delegate Delegate是Refrence 將方法(method)物件化
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void MethodONE(string myMsg) //委派 回傳型態數量都要一樣
        {
            string strOut = "Methodone 執行,傳遞數值:\n"+myMsg;
            MessageBox.Show(strOut);
        }
        void passDelegatMethod(MyDelegate myDelegateObj)
        {
            myDelegateObj("成功執行!!");
        }


        private void btnDelegate_Click(object sender, EventArgs e)
        {//測試Delegate
            MyDelegate delegateTest = MethodONE;
            passDelegatMethod(delegateTest);
        }

        private void btnAction_Click(object sender, EventArgs e)//沒有回傳值
        {
            Action<int, int> actionPlus = plus;
            actionPlus(7, 8);
        }

        void plus(int a,int b) 
        {
            int sum =a+ b;
            MessageBox.Show("action demo"+sum);
        }
        private void btnFunc_Click(object sender, EventArgs e)//有回傳值
        {
            Func<int, int, int, int> funSum = sum;
            MessageBox.Show("Func demo:"+funSum(1,2,3));
        }

        int sum(int a, int b,int c) 
        {
            int sum = a + b + c;

            return sum;
        }


    }
}
