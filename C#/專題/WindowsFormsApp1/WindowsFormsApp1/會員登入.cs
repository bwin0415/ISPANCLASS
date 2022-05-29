using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class 會員登入 : Form
    {
        bool acountHint = false;

        ToolTip toolTip1 = new ToolTip();
        string myDBConnctionString = "";
        public 會員登入()
        {
            InitializeComponent();
        }

        private void 會員登入_Load(object sender, EventArgs e)
        {
            #region 提示字元
            txtAccount.Text = "請輸入會員編號";
            txtAccount.ForeColor = Color.LightGray;
            acountHint = false;

            
            #endregion
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Homework";
            scsb.IntegratedSecurity = true;
            myDBConnctionString = scsb.ToString();
            txtAccount.LostFocus += new EventHandler(txtAccount_LostFOcus);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string name = "";
            string Id = "";
            string account = "";
            int secnum = 0;
         
            int memberPoint = 0;
            SqlConnection con = new SqlConnection(myDBConnctionString);
            con.Open();
            Id = txtAccount.Text;
            string strSQL = "select * from member where Id=@SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {

                    secnum = (int)reader["密碼"];
                    name = (string)reader["姓名"];
                    account = Id;
                    memberPoint = (int)reader["點數"];
                }
                reader.Close();
                con.Close();
                if ((txtAccount.Text == account) && (mtxtNum.Text == secnum.ToString()))
                {
                    MessageBox.Show("登入成功" + "哈囉" + name);
                    GlobalVar.User = name;
                    GlobalVar.UserId = Int32.Parse(Id);
                    GlobalVar.UserPoint = memberPoint;
                    GlobalVar.memberLogin = this;
                    購物單 Cart = new 購物單();
                    GlobalVar.Cart = Cart;
                    Cart.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("帳號密碼錯誤");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("請輸入帳號密碼");
                
            }

            
            


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            GlobalVar.memberLogin = this;
            會員註冊 Registerform = new 會員註冊();
            GlobalVar.memberRigister = Registerform;
            Registerform.Show();
            Hide();

        }

        private void btnClearTxt_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "";
            mtxtNum.Text = "";
        }

        private void txtAccount_Enter(object sender, EventArgs e)
        {
            if (acountHint == false)
            {
                txtAccount.Text = "";
                txtAccount.ForeColor = Color.Black;
            }
        }
        private void txtAccount_LostFOcus(object sender , EventArgs e)
        {
            if (txtAccount.Text == "")
            {
                txtAccount.Text = "請輸入會員編號";
                txtAccount.ForeColor = Color.LightGray;
                acountHint = false;
            }
            else
            {
                acountHint = true;
            }
        }

        private void mtxtNum_Enter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "提示訊息";
            toolTip1.SetToolTip(mtxtNum, "密碼為非0開頭的4到8位數字");
            toolTip1.AutoPopDelay = 60000;
        }

        private void txtAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void mtxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }
    }
}
