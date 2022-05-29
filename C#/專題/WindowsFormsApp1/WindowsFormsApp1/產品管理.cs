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

    public partial class txtOrdercount : Form
    {

        List<int> searchIDs = new List<int>();//進階搜尋結果-存取索引值 primykey
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string myDBConnctionString = "";
        public txtOrdercount()
        {
            InitializeComponent();
        }

        private void 產品管理_Load(object sender, EventArgs e)
        {
            lblId.Text = "";
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Homework";
            scsb.IntegratedSecurity = true;
            myDBConnctionString = scsb.ToString();
            memberDataPrint();
        }
        void memberDataPrint()
        {
            
           SqlConnection con = new SqlConnection(myDBConnctionString);
            con.Open();
            string strSQL = "select * from product;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strselID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//重要******** 找出表單的索引直
                int intSelId = 0;
                bool isID = Int32.TryParse(strselID, out intSelId);
                if (isID == true)
                {

                    SqlConnection con = new SqlConnection(myDBConnctionString);
                    con.Open();
                    string strSQL = "select * from product where Id = @SearchID ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblId.Text = string.Format("{0}", reader["Id"]);
                        txtName.Text = string.Format("{0}", reader["產品名稱"]);
                        txtPrice.Text = string.Format("{0}", reader["產品價格"]);
                        txtCount.Text = string.Format("{0}", reader["產品庫存量"]);
                        txtOnway.Text = string.Format("{0}", reader["產品在途量"]);




                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        lblId.Text = "";
                        txtName.Clear();
                        txtPrice.Clear();
                        txtCount.Clear();
                        txtOnway.Clear();

                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtOdernum.Text != ""|| lblId.Text != "")
            {

                int onway = 0;
                SqlConnection con = new SqlConnection(myDBConnctionString);
                con.Open();
                string strSQL = "select * from product where Id=@SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId",lblId.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                int ordercount = 0;
                if (Int32.TryParse(txtOdernum.Text, out ordercount))
                {
                    ordercount = Int32.Parse(txtOdernum.Text);
                }
                while (reader.Read())
                {
                    onway = (int)reader["產品在途量"];
                }
                reader.Close();
                onway += ordercount;
                strSQL = "update product set 產品在途量=@Onway from product where Id=@SearchId";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", lblId.Text);
                cmd.Parameters.AddWithValue("@Onway", onway);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows}筆資料修改成功");
                memberDataPrint();
            }
            else
            {
                MessageBox.Show("訂購數量及產品編號不能空白");
            }


        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtOdernum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtOrdercount_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.cashier.Show();
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            if ( lblId.Text != "")
            {

                int onway = 0;
                SqlConnection con = new SqlConnection(myDBConnctionString);
                con.Open();
                string strSQL = "select * from product where Id=@SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", lblId.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                int ordercount = 0;
    
                while (reader.Read())
                {
                    onway = (int)reader["產品在途量"];
                    ordercount = (int)reader["產品庫存量"];
                }
                reader.Close();
                ordercount += onway;
                onway = 0;
                strSQL = "update product set 產品在途量=@Onway ,產品庫存量=@Ordercount ,修改日期=@default from product where Id=@SearchId";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", lblId.Text);
                cmd.Parameters.AddWithValue("@Onway", onway);
                cmd.Parameters.AddWithValue("@Ordercount", ordercount);
                cmd.Parameters.AddWithValue("@default", DateTime.Now);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows}筆資料修改成功");
                memberDataPrint();
            }
            else
            {
                MessageBox.Show("產品編號不能空白");
            }
        }
    }
}
