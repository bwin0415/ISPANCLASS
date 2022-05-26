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
    public partial class 購物單 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int memberPoint = 0;
        List<string> ListName = new List<string>();
        List<string> ListClass = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();
        List<int> Count = new List<int>();

        string myDBConnctionString = "";
        public 購物單()
        {
            InitializeComponent();
        }

        private void 購物單_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Homework";
            scsb.IntegratedSecurity = true;
            myDBConnctionString = scsb.ToString();
            lblName.Text = "哈囉，" + GlobalVar.User;
            LoadData();
        }
        void LoadData()
        {
            SqlConnection con = new SqlConnection(myDBConnctionString);
            con.Open();
            string strSQL = "select * from product;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();


            int i = 0;
            while (reader.Read())
            {
                listId.Add((int)reader["Id"]);
                ListName.Add((string)reader["產品名稱"]);
                listPrice.Add((int)reader["產品價格"]);
                ListClass.Add((String)reader["產品類別"]);


                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();

        }
        void ListMode()
        {
            listView2.Clear();
            listView2.View = View.Details;
            listView2.Groups.Add()
            listView2.Columns.Add("序號", 100);//欄位,寬度;
            listView2.Columns.Add("產品名稱", 200);
            listView2.Columns.Add("產品價格", 80);
            listView2.FullRowSelect = true;
            listView2.LargeImageList = null;
            listView2.SmallImageList = null;
            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("標楷體", 14, FontStyle.Regular);
                item.Text = listId[i].ToString();
                item.SubItems.Add((string)ListName[i]);//第二欄用subItem添加

                item.SubItems.Add(listPrice[i].ToString());
                item.Tag = listId[i];
                listView2.Items.Add(item);

            }
        }

    }
}
