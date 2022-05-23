using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class FormDetail : Form
    {
        public int pId = 0;
        string myDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool isChange = false;

        public FormDetail()
        {
            InitializeComponent();
        }



        private void FormDetail_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myDb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            if (pId<=0)
            {
                groupBoxAdd.Visible = true;
                groupBoxChange.Visible = false;
            }
            else
            {

                groupBoxAdd.Visible = false;
                groupBoxChange.Visible = true;
                ProductDetail();
            }


        }
        void ProductDetail() 
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from product where  Id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID",pId);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                lblID.Text = reader["Id"].ToString();
                txtName.Text = reader["pname"].ToString();
                txtprice.Text = reader["price"].ToString();
                txtPicDetail.Text = reader["pdesc"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i++;
            }
            reader.Close();
            con.Close();
        }

        private void btnPickPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            DialogResult R = f.ShowDialog();
            if (R==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);//f.SafeFileName取得副檔名
                Random rD = new Random();
                image_name =DateTime.Now.ToString("yyyyMMdHHmmss")+rD.Next(1000, 10000).ToString()+fileExt;
                isChange = true;
                Console.WriteLine(image_name);
            }
            else
            {
                isChange = false;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text!=""&&txtprice.Text!=""&&txtPicDetail.Text!=""&&pictureBox1.Image !=null)
            {
                if (isChange ==true)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    isChange = false;
                }
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update product set pname=@NewPname, price=@NewPrice, pimage=@NewPimage, pdesc=@NewPdesc where  Id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", pId);
                cmd.Parameters.AddWithValue("@NewPname", txtName.Text);
                int intPrice = 0;
                Int32.TryParse(txtprice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice",intPrice);
                cmd.Parameters.AddWithValue("@NewPimage",image_name);
                cmd.Parameters.AddWithValue("@NewPdesc",txtPicDetail.Text);
                int row = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改成功,影響"+row+"筆資料");

            }
            else
            {
                MessageBox.Show("所有欄未必填");
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txtName.Text = "";
            txtprice.Text = "";
            txtPicDetail.Text = "";
            image_name = "";
            pictureBox1.Image = null ;

        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtprice.Text != "" && txtPicDetail.Text != "" && pictureBox1.Image != null)
            {
                if (isChange == true)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    isChange = false;
                }
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into product values(@NewPname, @NewPrice, @NewPdesc, @NewPimage)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPname", txtName.Text);
                int intPrice = 0;
                Int32.TryParse(txtprice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                cmd.Parameters.AddWithValue("@NewPdesc", txtPicDetail.Text);
                int row = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改成功,影響" + row + "筆資料");

            }
            else
            {
                MessageBox.Show("所有欄未必填");
            }
        }
    }
}
