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
    public partial class 結帳 : Form
    {
        bool correctId = false;
        List<CashierItem> Clist = new List<CashierItem>();
        int empId = 0;
        string name = "";
        int id = 0;
        int price = 0;
        string itemclass = "";
        string str = "";
        int sum = 0;

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string myDBConnctionString = "";
        public 結帳()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clist.Clear();
            CashierItem c;
            txtCusmorId.ReadOnly = true;
            txtCusmorPhone.ReadOnly = true;
            txtFlieghtNO.ReadOnly = true;
            dtpA.Visible = false;
            btnCheckFlieght.Visible = false;
            btnCustorIdCheck.Visible = false;
            foreach (ListViewItem item in GlobalVar.lvItemCollection)
            {

                id = Int32.Parse(item.Text);
                name = item.SubItems[1].Text;
                price = Int32.Parse(item.SubItems[2].Text);
                itemclass = item.Tag.ToString();
                str = string.Format("產品序號：{0} 產品類別：{1} 產品價格：{2} 產品名稱:{3}", id, itemclass, price, name);
                c = new CashierItem(name, id, itemclass, price);
                lBoxOrder.Items.Add(str);
                Clist.Add(c);
            }
            Sum();
            lblTotalPay.Text = "總價為：" + sum.ToString() + "元";
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Homework";
            scsb.IntegratedSecurity = true;
            myDBConnctionString = scsb.ToString();
        }
        void Sum()
        {
            sum = 0;
            foreach (ListViewItem item in GlobalVar.lvItemCollection)
            {

                int uniprice = Int32.Parse(item.SubItems[2].Text);
                sum += uniprice;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mtxtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(myDBConnctionString);
            con.Open();
            try
            {
                empId = Int32.Parse(txtId.Text);
            }
            catch (Exception)
            {

                Console.Write("姓名空白");
            }

            string strSQL = "select * from employee where Id=@SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", empId);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblName.Text = (string)reader["姓名"];
            }
            reader.Close();
            con.Close();

        }
        void empLogin(int id)
        {
            bool islogin = false;
            int a = 0;
            int b = 0;
            try
            {
                a = Int32.Parse(mtxtPwd.Text);
            }
            catch (Exception)
            {

                Console.WriteLine("密碼為空白");
            }
            SqlConnection con = new SqlConnection(myDBConnctionString);
            con.Open();
            string strSQL = "select * from employee where Id=@SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b = (int)reader["密碼"];
            }
            reader.Close();
            con.Close();
            if (a == b)
            {
                islogin = true;

            }
            else
            {
                islogin = false;
            }
            if (islogin)
            {
                txtCusmorId.ReadOnly = false;
                txtCusmorPhone.ReadOnly = false;
                txtFlieghtNO.ReadOnly = false;
                dtpA.Visible = true;
                btnCheckFlieght.Visible = true;
                btnCustorIdCheck.Visible = true;
            }
            else
            {
                txtCusmorId.ReadOnly = true;
                txtCusmorPhone.ReadOnly = true;
                txtFlieghtNO.ReadOnly = true;
                dtpA.Visible = false;
                btnCheckFlieght.Visible = false;
                btnCustorIdCheck.Visible = false;
            }
        }

        private void txtCusmorPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mtxtPwd_TextChanged(object sender, EventArgs e)
        {
            empLogin(empId);
        }

        private void btnCheckFlieght_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(myDBConnctionString);
            con.Open();
            string strSQL = "select * from FrieghtNo where 航班代號=@SearchName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", txtFlieghtNO.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("航班代號正確");
            }
            else
            {
                MessageBox.Show("航班代號錯誤");
            }
            reader.Close();
            con.Close();
        }

        private void btnCustorIdCheck_Click(object sender, EventArgs e)
        {
            if (checkId(txtCusmorId.Text))
            {
                MessageBox.Show("身分證號碼正確");
            }
            else
            {
                MessageBox.Show("身分證號碼錯誤");
            }
        }

        #region Reload
        void FixSum()
        {
            sum = 0;
            foreach (CashierItem item in Clist)
            {

                int uniprice = item.price;
                sum += uniprice;
            }
            lblTotalPay.Text = "總價為：" + sum.ToString() + "元";
        }
        #endregion
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
                    correctId = true;
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

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            lBoxOrder.Items.Clear();
            Clist.Clear();
            FixSum();
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {

            if (lBoxOrder.SelectedIndex >= 0)
            {
                int selIndex = lBoxOrder.SelectedIndex;
                lBoxOrder.Items.RemoveAt(selIndex);
                Clist.RemoveAt(selIndex);
                GlobalVar.lvItemCollection.RemoveAt(selIndex);
            }
            FixSum();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void 結帳_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.Cart.Show();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {

            if (txtCusmorPhone.Text != ""&& correctId )
            {
                string strFileAddress = @"C:..\..\Desktop";
                Random myRnd = new Random();
                int myNum = myRnd.Next(1000, 9999);
                string strFileName = DateTime.Now.ToString("yyMMddHHmmss") + myNum.ToString() + @"訂購單.txt";
                string OrderlistID = DateTime.Now.ToString("yyMMddHHmmss") + myNum.ToString();
                string strFile = strFileAddress + @"\" + strFileName;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = strFileAddress;
                sfd.FileName = strFileName;
                sfd.Filter = "Text File|*.txt";

                DialogResult R = sfd.ShowDialog();
                if (R == DialogResult.OK)
                {
                    strFile = sfd.FileName;
                }
                else
                {
                    return;
                }
                //////////////訂購單存檔訂購單存檔
                List<string> listOrderInfo = new List<string>();
                CashierItem c;
                listOrderInfo.Add("****************提貨單**************");
                listOrderInfo.Add("--------------------------------------");
                listOrderInfo.Add("訂購時間：" + DateTime.Now.ToString());
                listOrderInfo.Add("提貨單號" + OrderlistID);
                listOrderInfo.Add("--------------------------------------");
                foreach (ListViewItem item in GlobalVar.lvItemCollection)
                {
                    id = Int32.Parse(item.Text);
                    name = item.SubItems[1].Text;
                    price = Int32.Parse(item.SubItems[2].Text);
                    itemclass = item.Tag.ToString();
                    str = string.Format("產品序號：{0} 產品類別：{1} 產品價格：{2} 產品名稱:{3}", id, itemclass, price, name);
                    listOrderInfo.Add(str);

                }
                FixSum();
                listOrderInfo.Add("--------------------------------------");
                listOrderInfo.Add("總價：" + sum);
                listOrderInfo.Add("*****************謝謝光臨**************");

                System.IO.File.WriteAllLines(strFile, listOrderInfo, Encoding.UTF8);
                MessageBox.Show("存檔成功");
            }
            else
            {
                MessageBox.Show("請再次確認顧客資訊"); 
            }

        }

        private void btnSearchFlieghtNo_Click(object sender, EventArgs e)
        {
            string str = "";
            SqlConnection con = new SqlConnection(myDBConnctionString);
            con.Open();
            string strSQL = "select * from FrieghtNo";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                str += (string)reader["航班代號"] + "\n";
            }
            reader.Close();
            con.Close();
            MessageBox.Show(str);
        }



        private void btnProductSearch_Click(object sender, EventArgs e)
        {   string a = "";
            SqlConnection con = new SqlConnection(myDBConnctionString);
            con.Open();
            string strSQL = "select * from employee where Id=@SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", empId);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                a = (string)reader["職稱"];
            }
            if (a=="經理"||a=="組長")
            {
                GlobalVar.cashier = this;
                txtOrdercount productmanagement = new txtOrdercount();
                GlobalVar.productManagement = productmanagement;
                productmanagement.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("不具有此權限");
            }
        }

        private void txtCusmorId_KeyPress(object sender, KeyPressEventArgs e)
        {
            correctId = false;
        }
    }
}

