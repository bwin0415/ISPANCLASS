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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string myDBConnectionString = "";
        List<string> ListName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myDb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            LoadingSQL();


        }
        void LoadingSQL() 
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from product;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            int i = 0;
            while (reader.Read())
            {
                listId.Add((int)reader["Id"]); 
                ListName.Add((string)reader["pname"]);
                listPrice.Add((int)reader["price"]);
                image_name = (string)reader["pimage"];
                imageList1.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料",i);
            reader.Close();
            con.Close();
        }

        private void btnPictureMode_Click(object sender, EventArgs e)
        {
            PictureMode();
        }
        void PictureMode()
        {
            listView1.Clear();
            listView1.View = View.LargeIcon; //LargeIcon,smallIcon,list,tile
            imageList1.ImageSize = new Size(120, 120);
            listView1.LargeImageList = imageList1; //LargeIcon,tile;
           // listView1.SmallImageList = imageList1; //smallIcon,list;
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = ListName[i];
                item.Tag = listId[i];
                listView1.Items.Add(item);
            }
        }
        private void btnListMode_Click(object sender, EventArgs e)
        {
            ListMode();
        }
        void ListMode()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("序號", 100);//欄位,寬度;
            listView1.Columns.Add("產品名稱", 200);
            listView1.Columns.Add("產品價格", 80);
            listView1.FullRowSelect = true;
            listView1.LargeImageList = null; 
            listView1.SmallImageList = null; 
            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listId[i].ToString();
                item.SubItems.Add((string)ListName[i]);//第二欄用subItem添加
                item.SubItems.Add(listPrice[i].ToString());
                item.Tag = listId[i];
                listView1.Items.Add(item);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            FormDetail myFormDetail = new FormDetail();
            
            myFormDetail.ShowDialog();//獨佔開啟
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            listId.Clear();
            ListName.Clear();
            listPrice.Clear();
            imageList1.Images.Clear();
            LoadingSQL();
            if (listView1.View==View.Details)
            {
                ListMode();
            }
            else
            {
                PictureMode();
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            FormDetail myFormDetail = new FormDetail();
            myFormDetail.pId = (int)listView1.SelectedItems[0].Tag;//選取項目的第1欄的標籤
            myFormDetail.ShowDialog();//獨佔開啟
            
        }

    }
}
