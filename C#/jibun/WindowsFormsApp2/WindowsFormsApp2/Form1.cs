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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn公分轉英吋_Click(object sender, EventArgs e)
        {
            if (Txt公分.Text!="")// "" ==>空字串
            {
                try
                {
                    float myCm = 0.0f;
                    float myInch = 0.0f;
                    string strInput = Txt公分.Text;
                    myCm = System.Convert.ToSingle(strInput);
                    myInch = myCm * 0.3937f;
                    //Txt英吋.Text =Convert.ToString( myInch);
                    Txt英吋.Text = string.Format("{0:F}", myInch);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "發生錯誤");
                    //MessageBox.Show("輸入公分格式錯誤,請重新輸入","輸入錯誤");
                    Txt英吋.Clear();
                    
                }
                finally 
                {
                    Txt平方公尺.Clear();
                    Txt公分.Clear();
                    Txt公斤.Clear();
                    Txt磅.Clear();
                    Txt坪數.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入公分數值");
            }
        }

        private void btn英吋轉公分_Click(object sender, EventArgs e)
        {
            if (Txt英吋.Text != "")// "" ==>空字串
            {
                try
                {
                    float myCm = 0.0f;
                    float myInch = 0.0f;
                    string strInput = Txt英吋.Text;
                    myInch = System.Convert.ToSingle(strInput);
                    myCm = myInch / 0.3937f;
                    //Txt英吋.Text =Convert.ToString( myInch);
                    Txt公分.Text = string.Format("{0:F}", myCm);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "發生錯誤");
                    //MessageBox.Show("輸入英吋格式錯誤,請重新輸入","輸入錯誤");
                    Txt公分.Clear();
                    
                }
                finally 
                {
                    Txt平方公尺.Clear();
                    Txt英吋.Clear();
                    Txt公斤.Clear();
                    Txt磅.Clear();
                    Txt坪數.Clear();

                }
            }
            else
            {
                MessageBox.Show("請輸入英吋數值");
            }
        }

        private void btn坪數轉平方公尺_Click(object sender, EventArgs e)
        {
            if (Txt坪數.Text!="")
            {
                try
                {
                    double myM = 0.0;
                    double myPIN = 0.0;
                    string strInput = Txt坪數.Text;
                    myPIN = Convert.ToDouble(strInput);
                    myM = myPIN * 3.3058;
                    Txt平方公尺.Text = string.Format("{0:F3}", myM);

                }
                catch (Exception error)
                {

                    MessageBox.Show(error.ToString(), "發生錯誤");
                    //MessageBox.Show("輸入坪數格式錯誤,請重新輸入","輸入錯誤");
                    Txt平方公尺.Clear();
                }
                finally 
                {
                    Txt公分.Clear();
                    Txt英吋.Clear();
                    Txt公斤.Clear();
                    Txt磅.Clear();
                    Txt坪數.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入坪數數值");
            }

        }

        private void btn平方公尺轉坪數_Click(object sender, EventArgs e)
        {
            if (Txt平方公尺.Text.Length>0)
            {
                double myM, myPin = 0.0;
                myM = Convert.ToDouble(Txt平方公尺.Text);
                myPin = myM / 3.3058f;
                Txt坪數.Text = myPin.ToString();
            }
            else
            {
                MessageBox.Show("請輸入平方公尺數值");
            }
        }

        private void btn公斤轉磅_Click(object sender, EventArgs e)
        {
            if (Txt公斤.Text != "")
            {
                double myKg = 1.0;
                double myP = 1.0;
                bool isRight = false;
                isRight = System.Double.TryParse(Txt公斤.Text,out myKg);//TryParse試著解析...  out跟ref是一樣的差別在out允許null
                if (isRight)
                {
                    myP = myKg * 2.2;
                    Txt磅.Text = string.Format("{0:F1}", myP);
                }
                else
                {
                    MessageBox.Show("轉換失敗,請輸入正確的公斤格式數值");
                    Txt磅.Clear();
                }
                Txt公分.Clear();
                Txt英吋.Clear();
                Txt坪數.Clear();
                Txt平方公尺.Clear();
                Txt公斤.Clear();

            }
            else
            {
                MessageBox.Show("請輸入公斤");
            }

        }

        private void btn磅轉公斤_Click(object sender, EventArgs e)
        {
            if (Txt磅.Text.Length > 0)
            {
                double myKg, myP = 0.0;
                myP = Convert.ToDouble(Txt磅.Text);
                myKg = myP / 2.2;
                Txt公斤.Text = myKg.ToString();
            }
            else
            {
                MessageBox.Show("請輸入磅數值");
            }
        }
    }
}
