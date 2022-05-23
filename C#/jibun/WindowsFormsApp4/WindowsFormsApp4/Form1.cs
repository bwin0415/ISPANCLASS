using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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

        private void btn_VTEST_Click(object sender, EventArgs e)
        {
            int x = 5;
            lbl_V1.Text = "變數再傳遞前的值" + x.ToString();
            CallByValue(x);
            lbl_V3.Text = "變數再傳遞後的值" + x.ToString();
        }        
        private void btn_RTEST_Click(object sender, EventArgs e)
        {
            int x = 5;
            lbl_R1.Text = "變數再傳遞前的值" + x.ToString();
            CallByReference(ref x);
            lbl_R3.Text = "變數再傳遞後的值" + x.ToString();
        }

        void CallByValue(int y) 
        {
            y += 1;
            lbl_V2.Text = "參數在方法裡面的值" + y.ToString();
        }
        void CallByReference(ref int y) //風險性++
        {
            y += 1;
            lbl_R2.Text = "參數在方法裡面的值" + y.ToString();
        }
    }
}
