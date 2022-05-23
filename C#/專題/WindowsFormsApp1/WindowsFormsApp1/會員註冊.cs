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
    public partial class 會員註冊 : Form
    {

        ToolTip toolTip1 = new ToolTip();
        int memberId = 0;
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string myDBConnctionString = "";
        public 會員註冊()
        {
            InitializeComponent();
        }

        private void 會員註冊_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Homework";
            scsb.IntegratedSecurity = true;
            myDBConnctionString = scsb.ToString();
            txtNum.Enter += new EventHandler(txtNum_Enter);
            txtNumSec.Enter += new EventHandler(txtNumSec_Enter);
            txtPhone.Enter += new EventHandler(txtPhone_Enter);
        }

        #region 輸入事件
        private void txtNum_Enter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "提示訊息";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.SetToolTip(txtNum, "密碼為非0開頭的4到8位數字");
            toolTip1.AutoPopDelay = 60000;
        }
        private void txtNumSec_Enter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "提示訊息";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.SetToolTip(txtNumSec, "密碼為非0開頭的4到8位數字");
            toolTip1.AutoPopDelay = 60000;
        }
        private void txtPhone_Enter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "提示訊息";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.SetToolTip(txtPhone, "請輸入手機號碼");
            toolTip1.AutoPopDelay = 60000;
        }

        #endregion
        #region 按鈕事件
        private void btnRegister_Click(object sender, EventArgs e)
        {


            if (txtEmail.Text != "" && txtName.Text != "" && txtId.Text != "" && txtNum.Text != "" && txtPhone.Text != "")
            {
                string checkB = txtId.Text;

                if (txtNum.Text != txtNumSec.Text)
                {


                    MessageBox.Show("二次密碼不相同");

                }
                else if (txtPhone.TextLength != 10)
                {
                    MessageBox.Show("請填入正確的手機號碼");
                }
                else if (!checkId(checkB))
                {
                    MessageBox.Show("請填入正確填入身分證字號");
                }
                else
                {
                    SqlConnection con = new SqlConnection(myDBConnctionString);
                    con.Open();
                    string strSQL = "insert into member values(@Newname, @NewPhone, @NewMail,@NewDate,@NewPoint,@Newnum,@NewID,@CreateDate,@ModifyDate, default)";

                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Newname", txtName.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@NewMail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NewDate", dtpbirthday.Value);
                    cmd.Parameters.AddWithValue("@NewPoint", 0);
                    cmd.Parameters.AddWithValue("@Newnum", txtNum.Text);
                    cmd.Parameters.AddWithValue("@NewID", txtId.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ModifyDate", DateTime.Now);
                    int row = cmd.ExecuteNonQuery();
                    strSQL = "Select * from member Where 姓名 = @Newname and 身分證 = @NewID";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Newname", txtName.Text);
                    cmd.Parameters.AddWithValue("@NewID", txtId.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        memberId = (int)reader["Id"];
                    }

                    reader.Close();
                    con.Close();
                    MessageBox.Show("資料修改成功,影響" + row + "筆資料");
                    MessageBox.Show("會員編號為" + memberId);
                    lblMemberId.Text = "會員編號為：" + memberId.ToString();

                }
            }
            else
            {
                MessageBox.Show("請將註冊表格填完");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 會員註冊_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.memberLogin.Show();
        }

        #endregion
        #region 自訂方法

        #region 身分證檢查
        private bool checkId(string user_id) //檢查身分證字號
        {
            int[] uid = new int[10]; //數字陣列存放身分證字號用
            int chkTotal; //計算總和用

            if (user_id.Length == 10) //檢查長度
            {
                user_id = user_id.ToUpper(); //將身分證字號英文改為大寫

                //將輸入的值存入陣列中
                for (int i = 1; i < user_id.Length; i++)
                {
                    try
                    {
                        uid[i] = Int32.Parse(user_id.Substring(i, 1));
                    }
                    catch (Exception e)
                    {

                        return false;
                    }

                }
                //將開頭字母轉換為對應的數值
                switch (user_id.Substring(0, 1).ToUpper())
                {
                    case "A": uid[0] = 10; break;
                    case "B": uid[0] = 11; break;
                    case "C": uid[0] = 12; break;
                    case "D": uid[0] = 13; break;
                    case "E": uid[0] = 14; break;
                    case "F": uid[0] = 15; break;
                    case "G": uid[0] = 16; break;
                    case "H": uid[0] = 17; break;
                    case "I": uid[0] = 34; break;
                    case "J": uid[0] = 18; break;
                    case "K": uid[0] = 19; break;
                    case "L": uid[0] = 20; break;
                    case "M": uid[0] = 21; break;
                    case "N": uid[0] = 22; break;
                    case "O": uid[0] = 35; break;
                    case "P": uid[0] = 23; break;
                    case "Q": uid[0] = 24; break;
                    case "R": uid[0] = 25; break;
                    case "S": uid[0] = 26; break;
                    case "T": uid[0] = 27; break;
                    case "U": uid[0] = 28; break;
                    case "V": uid[0] = 29; break;
                    case "W": uid[0] = 32; break;
                    case "X": uid[0] = 30; break;
                    case "Y": uid[0] = 31; break;
                    case "Z": uid[0] = 33; break;
                }
                //檢查第一個數值是否為1.2(判斷性別)
                if (uid[1] == 1 || uid[1] == 2)
                {
                    chkTotal = (uid[0] / 10 * 1) + (uid[0] % 10 * 9);

                    int k = 8;
                    for (int j = 1; j < 9; j++)
                    {
                        chkTotal += uid[j] * k;
                        k--;
                    }

                    chkTotal += uid[9];

                    if (chkTotal % 10 != 0)
                    {
                        return false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        #endregion

        #endregion
    }
}
