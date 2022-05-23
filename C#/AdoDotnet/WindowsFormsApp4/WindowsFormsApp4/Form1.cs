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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int marriageState;
        SqlConnectionStringBuilder scsb; //SQL連線字串建立器
        string myDBConnectionString="";
        List<int> searchIDs = new List<int>();//進階搜尋結果-存取索引值 primykey

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";//.為本機
            scsb.InitialCatalog = "mydb"; //資料庫
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();//資料庫連線字串

            cBoxField.Items.Add("姓名");
            cBoxField.Items.Add("電話");
            cBoxField.Items.Add("Email");
            cBoxField.Items.Add("地址");
            cBoxField.SelectedIndex = 0;

            rBox0.Checked = true;
            memberDataPrint();
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            //SOP
            //STEP 1
            SqlConnection con = new SqlConnection(myDBConnectionString);//建立資料庫連線物件
            con.Open();//開啟連線
            string strSQL = "select top 100 * from Persons go";//執行SQL命令
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();//讀取資料集 ExecuteReader()會回傳資料集 SQL語法的結果存在裡面



            string strMsg = "";
            int i = 0;//計數器

            while (reader.Read())//reader.Read=有讀到TRUE沒讀到FALSE
            {
                //strMsg += (int)reader["ID"] + (string)reader["姓名"] + (string)reader["電話"] + "\n";
                strMsg += string.Format("Id：{0} 姓名：{1} 電話：{2} 地址：{3} Email：{4} 生日：{5} 婚姻狀態：｛6｝ 點數：{7}\n", reader["Id"], reader["姓名"], reader["電話"], reader["地址"], reader["Email"], reader["生日"], reader["婚姻狀態"], reader["會員點數"]);                
                i += 1;
            }
            strMsg += "資料筆數" + i.ToString();

            reader.Close();//重要一定要做 關閉資料庫釋放資員
            con.Close();//重要一定要做    關閉連線
            //資料管理-後進先出,先進後出

            MessageBox.Show(strMsg);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from Persons where 姓名 like @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL,con);
                cmd.Parameters.AddWithValue("@SearchName","%"+txtName.Text+"%");//cmd參數式寫法(1參數名稱,2參數內容)
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblID.Text = string.Format("{0}",reader["Id"]);
                    txtName.Text = string.Format("{0}", reader["姓名"]);
                    txtPhone.Text = string.Format("{0}", reader["電話"]);
                    txtAddress.Text = string.Format("{0}", reader["地址"]);
                    txtEmail.Text = string.Format("{0}", reader["Email"]);
                    txtPoint.Text = string.Format("{0}", reader["會員點數"]);
                    dtpbirthday.Value = Convert.ToDateTime(reader["生日"]);
                    chbMarrige.Checked = Convert.ToBoolean(reader["婚姻狀態"]);


                    
                }
                else 
                {
                    MessageBox.Show("查無此人");
                    lblID.Text = "";
                    txtName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    txtEmail.Clear();
                    txtPoint.Clear();
                    dtpbirthday.Value = DateTime.Now;
                    chbMarrige.Checked = false;
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名關鍵字搜尋");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text!=""&&txtPhone.Text!="")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into Persons values (@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirthday,@NewMarriage,@NewPoints);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtpbirthday.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chbMarrige.Checked);
                int intPoint = 0;
                Int32.TryParse(txtPoint.Text, out intPoint);
                cmd.Parameters.AddWithValue("@NewPoints", intPoint);//cmd參數式寫法(1參數名稱,2參數內容)

                int rows = cmd.ExecuteNonQuery();//執行不查詢
                con.Close();
                MessageBox.Show($"{rows}筆資料新增成功");
            }
            else
            {
                MessageBox.Show("姓名電話必須填寫");
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if (intID > 0 &&txtName.Text!="" && txtPhone.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update Persons SET 姓名 = @Name,電話 = @Phone,地址 = @Address,Email = @Email, 生日 = @Birthday,婚姻狀態 = @Marriage,會員點數 = @Points from Persons where Id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Birthday", dtpbirthday.Value);
                cmd.Parameters.AddWithValue("@Marriage", chbMarrige.Checked);
                int intPoint = 0;
                Int32.TryParse(txtPoint.Text, out intPoint);
                cmd.Parameters.AddWithValue("@Points", intPoint);//cmd參數式寫法(1參數名稱,2參數內容)

                int rows = cmd.ExecuteNonQuery();//執行不查詢
                con.Close();
                MessageBox.Show($"{rows}筆資料修改成功");    
          
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if (intID>0)
            {

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "Delete from Persons where Id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                
                cmd.Parameters.AddWithValue("@SearchID", intID);
                int rows = cmd.ExecuteNonQuery();//執行不查詢
                con.Close();
                lblID.Text = "";
                txtName.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPoint.Clear();
                dtpbirthday.Value = DateTime.Now;
                chbMarrige.Checked = false;
                MessageBox.Show($"{rows}筆資料新增成功");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPoint.Clear();
            dtpbirthday.Value = DateTime.Now;
            chbMarrige.Checked = false;
        }

        private void cBoxField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            lBoxAns.Items.Clear();
            searchIDs.Clear();
            string strFieldName = cBoxField.SelectedItem.ToString();

            if (txtKeyword.Text!="")
            {
                string strSQL = "";
                if (marriageState==100)
                {
                 strSQL = "select * from Persons where (" + strFieldName + " like @SearchName) and(生日 >= @StartDate and 生日 <= @EndDate)";
                }
                else if (marriageState == 101)
                {
                    strSQL = "select * from Persons where (" + strFieldName + " like @SearchName) and(生日 >= @StartDate and 生日 <= @EndDate) and 婚姻狀態 = 0";
                }
                else if (marriageState == 102)
                {
                    strSQL = "select * from Persons where (" + strFieldName + " like @SearchName) and(生日 >= @StartDate and 生日 <= @EndDate) and 婚姻狀態 = 1";
                }
                
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@SearchName", "%" + txtKeyword.Text + "%");
                cmd.Parameters.AddWithValue("@StartDate", dtpStart.Value);
                cmd.Parameters.AddWithValue("@EndDate", dtpEnd.Value);
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    lBoxAns.Items.Add((string)reader["姓名"]);
                    searchIDs.Add((int)reader["Id"]);
                    i += 1;
                }
                if (i<=0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }
        }
        
        private void lBoxAns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxAns.SelectedIndex>=0)
            {
                int intID = searchIDs[lBoxAns.SelectedIndex];
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from Persons where Id = @SearchID ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID",intID);
                SqlDataReader reader = cmd.ExecuteReader(); 

                    if (reader.Read())
                {
                    lblID.Text = string.Format("{0}", reader["Id"]);
                    txtName.Text = string.Format("{0}", reader["姓名"]);
                    txtPhone.Text = string.Format("{0}", reader["電話"]);
                    txtAddress.Text = string.Format("{0}", reader["地址"]);
                    txtEmail.Text = string.Format("{0}", reader["Email"]);
                    txtPoint.Text = string.Format("{0}", reader["會員點數"]);
                    dtpbirthday.Value = Convert.ToDateTime(reader["生日"]);
                    chbMarrige.Checked = Convert.ToBoolean(reader["婚姻狀態"]);



                }
                else
                {
                    MessageBox.Show("查無此人");
                    lblID.Text = "";
                    txtName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    txtEmail.Clear();
                    txtPoint.Clear();
                    dtpbirthday.Value = DateTime.Now;
                    chbMarrige.Checked = false;
                }
                reader.Close();
                con.Close();
            }
        }

        private void rBox0_CheckedChanged(object sender, EventArgs e)
        {
            marriageState = 100;
            lBoxAns.Items.Clear();
        }

        private void rBox1_CheckedChanged(object sender, EventArgs e)
        {
            marriageState = 101;
            lBoxAns.Items.Clear();
        }

        private void rBox2_CheckedChanged(object sender, EventArgs e)
        {
            marriageState = 102;
            lBoxAns.Items.Clear();
        }

        void memberDataPrint()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select Id as 會員編號, 姓名,電話,Email,會員點數,婚姻狀態 from Persons";
            SqlCommand cmd = new SqlCommand(strSQL,con);
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
            if (e.RowIndex>=0)
            {
                string strselID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//重要******** 找出表單的索引直
                int intSelId = 0;
                bool isID = Int32.TryParse(strselID,out intSelId);
                if (isID == true)
                {
                    
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "select * from Persons where Id = @SearchID ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblID.Text = string.Format("{0}", reader["Id"]);
                        txtName.Text = string.Format("{0}", reader["姓名"]);
                        txtPhone.Text = string.Format("{0}", reader["電話"]);
                        txtAddress.Text = string.Format("{0}", reader["地址"]);
                        txtEmail.Text = string.Format("{0}", reader["Email"]);
                        txtPoint.Text = string.Format("{0}", reader["會員點數"]);
                        dtpbirthday.Value = Convert.ToDateTime(reader["生日"]);
                        chbMarrige.Checked = Convert.ToBoolean(reader["婚姻狀態"]);



                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        lblID.Text = "";
                        txtName.Clear();
                        txtPhone.Clear();
                        txtAddress.Clear();
                        txtEmail.Clear();
                        txtPoint.Clear();
                        dtpbirthday.Value = DateTime.Now;
                        chbMarrige.Checked = false;
                    }
                    reader.Close();
                    con.Close();
                }

            }
            
          
        }
    }
}
