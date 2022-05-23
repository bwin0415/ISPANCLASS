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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           /* string strUserID = "黃小貓";
            string strPassword = "23456";*/

            string[,] strIDps = 
            {
                {"黃小貓","23456" },
                {"王曉明","14725" },
                {"蔡小雅","58369" },
                {"施小彬","56789" },
                {"景小樂","96385" }
            };



            //思考練習：如何做鍵值對應陣列儲存比對帳號密碼
            for (int i = 0; i <=strIDps.GetUpperBound(0); i++)
            {
                if (txtPassword.Text == strIDps[i,1] && txtUser.Text == strIDps[i,0])
                {
                    MessageBox.Show("登入成功");
                    GlobalVar.目前使用者 = txtUser.Text;
                    Form1 form人員建立 = new Form1();
                    form人員建立.Show();
                    break;
                    

                }
                else
                {
                    lblMsg.Text = "輸入帳號密碼錯誤";
                    
                }
            }


        }


        private void btnClr_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            lblMsg.Text = "";
        }
    }
}
