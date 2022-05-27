using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Test
{
    public partial class Form1 : Form
    {//list加總多選
        int q = 0;
        string a = "";
        string b = "S124499229";
        string[] c;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                int x = 1;
                    x += i;
                listBox1.Items.Add(x);
                Console.WriteLine(listBox1.Items[i]);
            }
            a = b.ElementAt(0).ToString();
        Regex rex = new Regex("[a-zA-Z]");
            rex.IsMatch(a);
            if (rex.IsMatch(a))
            {
                Console.WriteLine("true");
            }
            int b = 0;
               
            Console.Write(b++);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            q = 0;
            foreach (int item in listBox1.SelectedIndices)
            {
                q +=Convert.ToInt32( listBox1.Items[item]);

            }
            Console.WriteLine(q);

            
        }
	/*
	//ToolTip：當游標停滯在某個控制項時，就會跳出一個小視窗
 	ToolTip toolTip1 = new ToolTip();
	//SetToolTip：定義控制項會跳出提示的文字
 	toolTip1.SetToolTip(textBox1, "please enter number!!");

	//以下為提示視窗的設定(通常會設定的部分)
	//ToolTipIcon：設定顯示在提示視窗的圖示類型。
	toolTip1.ToolTipIcon = ToolTipIcon.Info;
	//ForeColor：顧名思義就是前景顏色，你懂的!!XD
	toolTip1.ForeColor = Color.Blue;
	//BackColor：顧名思義就是背景顏色，你也懂的!!XD
	toolTip1.BackColor = Color.Gray;
	//AutoPopDelay：當游標停滯在控制項，顯示提示視窗的時間。(以毫秒為單位)
	toolTip1.AutoPopDelay=5000;
	//ToolTipTitle：設定提示視窗的標題。
	toolTip1.ToolTipTitle = "提示訊息"

	*/
    }
}
