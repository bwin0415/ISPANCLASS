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
        List<string> ListName = new List<string>();
        List<string> ListClass = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();
        int sum = 0;
        

        string myDBConnctionString = "";
        public 購物單()
        {
            InitializeComponent();
        }

        private void 購物單_Load(object sender, EventArgs e)
        {
            ListName.Clear();
            ListClass.Clear();
            listPrice.Clear();
            listPrice.Clear();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Homework";
            scsb.IntegratedSecurity = true;
            myDBConnctionString = scsb.ToString();
            lblName.Text = "哈囉，" + GlobalVar.User+" 現在所擁有的點數："+GlobalVar.UserPoint.ToString();
            LoadData();
            ListMode();
            ListModeCart();
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
                ListClass.Add((string)reader["產品類別"]);


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
            listView2.Columns.Add("產品序號", 100);//欄位,寬度;
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
                item.Tag = ListClass[i];
                listView2.Items.Add(item);

            }
        }
        void ListModeCart()
        {
            listView3.Clear();
            listView3.View = View.Details;
            listView3.Columns.Add("產品序號", 100);//欄位,寬度;
            listView3.Columns.Add("產品名稱", 200);
            listView3.Columns.Add("產品價格", 80);
            listView3.FullRowSelect = true;
            listView3.LargeImageList = null;
            listView3.SmallImageList = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            GlobalVar.memberLogin.Show();
            GlobalVar.CloseAllForm();
        }

        private void 購物單_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.memberLogin.Show();
        }

        private void btnAddCashierList_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = this.listView2.SelectedItems;
            ListViewItem item = new ListViewItem();
            item.Font = new Font("標楷體", 14, FontStyle.Regular);
            if (listView2.FocusedItem.Selected) {
                for (int i = 0; i < selected.Count; i++)
                {
                    item.Font = new Font("標楷體", 14, FontStyle.Regular);
                    item.Text = selected[i].Text;
                    item.SubItems.Add(selected[i].SubItems[1].Text);//第二欄用subItem添加
                    item.SubItems.Add(selected[i].SubItems[2].Text);

                    item.Tag = selected[i].Tag;

                    if (listView3.Items.Count < 1)
                    {
                        listView3.Items.Add(item);
                    }
                    else
                    {
                        bool isthesame = false;
                        for (int count = 0; count < listView3.Items.Count; count++)
                        {
                            if (listView3.Items[count].Tag.ToString() == selected[i].Tag.ToString())
                            {
                                isthesame = true;

                                break;
                            }
                        }
                        if (isthesame)
                        {
                            MessageBox.Show("已超出可購買數量");
                        }
                        else
                        {
                            listView3.Items.Add(item);

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇想加入購物車的商品");
            }
            Sum();
            lblSum.Text = "";
            lblSum.Text += "總價為：" + sum.ToString() + "元";
        }

        private void btnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            bool selected = listView3.FocusedItem.Selected;
            if (selected)
            {
                listView3.FocusedItem.Remove();
            }
            else
            {
                MessageBox.Show("請選擇想要移除的項目");
            }
            Sum();
            lblSum.Text = "";
            lblSum.Text += "總價為：" + sum.ToString() + "元";

        }

        private void btnRemoveALL_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            Sum();
            lblSum.Text = "";
            lblSum.Text +="總價為："+ sum.ToString()+"元";

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            GlobalVar.lvItemCollection = listView3.Items;
            GlobalVar.Cart = this;
            結帳 cashier = new 結帳();
            GlobalVar.cashier = cashier;
            cashier.Show();
            Hide();
        }
        void Sum()
        {
            sum = 0;
            ListView.ListViewItemCollection a = listView3.Items;
            foreach (ListViewItem item in a)
            {
             int uniprice = Int32.Parse (item.SubItems[2].Text);

                sum += uniprice;
            }
        }
    }
}
