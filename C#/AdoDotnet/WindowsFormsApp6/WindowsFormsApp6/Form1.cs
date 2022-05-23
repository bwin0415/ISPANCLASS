using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        List<Button> myDbuttonList = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myUserControlOne1.lblTitle.Text = "使用者控制項標題";
            myUserControlOne1.txtTextInput.Text = "請輸入文字";
            myUserControlOne1.btnUpdate.Text = "Modify Title";

            CreateButton(8,4);
            Random myRandom = new Random();
            int a =  myRandom.Next(1, 32);
            myDbuttonList[a].BackColor = Color.Red;
            SetMyLabelButton();
        }
        void CreateButton(int intRow,int intColumn)
        {
            int serialNO = 0;
            
            for (int i = 0; i <intRow; i++)
            {

                for (int J = 0; J <intColumn; J++)
                {

                    serialNO += 1;
                    Button dButton = new Button();
                    dButton.BackColor = Color.Pink;
                    dButton.ForeColor = Color.FromArgb(101, 0, 255);
                    /* dButton.Width = 150;
                     dButton.Height = 40;*/
                    dButton.Size = new Size(150, 40);
                    dButton.Font = new Font("微軟正黑體", 18);
                    dButton.Name = "btnDbutton" + serialNO;
                    dButton.Text = "動態生成"+ serialNO;
                    dButton.TextAlign = ContentAlignment.MiddleCenter;
                    dButton.Location = new Point(20+150*J, 20 + (45 * i));
                    dButton.Click += new EventHandler(btnDbutton_Click);
                    //+=事件指定運算子
                    //-=事件解除運算子
                    Controls.Add(dButton);
                    myDbuttonList.Add(dButton);
                }

            }
            Console.WriteLine(myDbuttonList.Count);


        }

        private void btnDbutton_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            if (myButton.BackColor==Color.Red)
            {
                myButton.BackColor = Color.Pink;

            }
            else
            {
                myButton.BackColor = Color.Red;
            }
            MessageBox.Show("按下按鈕"+myButton.Name);
        }
        void SetMyLabelButton()
        {
            MyLabelButton lblBtnOne = new MyLabelButton();
            lblBtnOne.BackColor = Color.LightSkyBlue;
            lblBtnOne.ForeColor = Color.Blue;
            lblBtnOne.Font=new Font("標楷體",16,FontStyle.Bold);
            lblBtnOne.Name = "lblBtnOne";
            lblBtnOne.Text = "自訂標籤文字";
            lblBtnOne.TextAlign = ContentAlignment.MiddleCenter;
            lblBtnOne.Size = new Size(300, 70);
            lblBtnOne.Location = new Point(1370, 500);
            lblBtnOne.myDButton.Click += new EventHandler(lblButton_Click);

            Controls.Add(lblBtnOne);
        }

        void lblButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show("按下"+button.Name);
        }
    }
}
