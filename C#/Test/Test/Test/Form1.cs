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
    {//list�[�`�h��
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
	//ToolTip�G���а����b�Y�ӱ���ɡA�N�|���X�@�Ӥp����
 	ToolTip toolTip1 = new ToolTip();
	//SetToolTip�G�w�q����|���X���ܪ���r
 	toolTip1.SetToolTip(textBox1, "please enter number!!");

	//�H�U�����ܵ������]�w(�q�`�|�]�w������)
	//ToolTipIcon�G�]�w��ܦb���ܵ������ϥ������C
	toolTip1.ToolTipIcon = ToolTipIcon.Info;
	//ForeColor�G�U�W��q�N�O�e���C��A�A����!!XD
	toolTip1.ForeColor = Color.Blue;
	//BackColor�G�U�W��q�N�O�I���C��A�A�]����!!XD
	toolTip1.BackColor = Color.Gray;
	//AutoPopDelay�G���а����b����A��ܴ��ܵ������ɶ��C(�H�@�����)
	toolTip1.AutoPopDelay=5000;
	//ToolTipTitle�G�]�w���ܵ��������D�C
	toolTip1.ToolTipTitle = "���ܰT��"

	*/
    }
}
