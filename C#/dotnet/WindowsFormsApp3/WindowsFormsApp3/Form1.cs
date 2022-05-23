using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<string> listItemName = new List<string>();//key
        List<string> listSugar = new List<string>();
        List<string> listIce = new List<string>();
        List<string> listOther = new List<string>();
        List<int> listItemprice = new List<int>();//value
        List<int> listOtherprice = new List<int>();//value
        //作業規格：加料價錢
        int itemCount=0,uniPrice=0,totalPay=0, itemOtherPrice=0;
        string itemName = "", itemSugar = "", itemIce = "", itemOtherName="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //key
            listItemName.Add("紅茶");
            listItemName.Add("綠茶");
            listItemName.Add("烏龍茶");
            listItemName.Add("奶茶");
            //value
            listItemprice.Add(20); 
            listItemprice.Add(20); 
            listItemprice.Add(20); 
            listItemprice.Add(40); 
            foreach (string itemname in listItemName) 
            {
                lboxItem.Items.Add(itemname);
            }
            //lboxItem.SelectedIndex = 1;//預選
            #region 杯數
            itemCount = 1;
            txtCount.Text = itemCount.ToString();
            #endregion
            #region 甜度
            listSugar.Add("正常");
            listSugar.Add("少糖");
            listSugar.Add("半糖");
            listSugar.Add("微糖");
            foreach (string itemname in listSugar)
            {
                cboxSuger.Items.Add(itemname);
            }
            cboxSuger.SelectedIndex = 0;
            #endregion


        }

        private void lboxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lboxItem.SelectedIndex;
            itemName = listItemName[selIndex];
            uniPrice = listItemprice[selIndex];
            lblUnitPrice.Text = uniPrice.ToString() + "元";
            totalPay = uniPrice * itemCount;
            lblTotalPrice.Text = totalPay.ToString()+"元";
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void cboxSuger_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cboxSuger.SelectedIndex;
            itemSugar = listSugar[selIndex];
        }

        private void cboxIce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxOther_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (lblTotalPrice.Text!="")
            {
                try
                {
                    itemCount = Convert.ToInt32(txtCount.Text);
                    totalPay = uniPrice * itemCount;
                    lblTotalPrice.Text = totalPay.ToString() + "元";
                    //作業規格：杯數避免與改正輸入錯誤
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString(), "字串為空值");
                }
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (txtName.Text!="")
            {
                ArrayList itemOrderInfo = new ArrayList();//作業要用自訂類別
                itemOrderInfo.Add(itemName);
                itemOrderInfo.Add(uniPrice);
                itemOrderInfo.Add(itemCount);
                itemOrderInfo.Add(totalPay);
                itemOrderInfo.Add(itemSugar);
                itemOrderInfo.Add(itemIce);
                itemOrderInfo.Add(itemOtherName);
                itemOrderInfo.Add(itemOtherPrice);
                GlobalVar.listOrderItem.Add(itemOrderInfo);
                GlobalVar.userInfo = txtName.Text;
                MessageBox.Show("已加入結帳單");
            }
            else 
            {
                MessageBox.Show("請輸入聯絡資訊");
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GlobalVar.formMenu = this;
            Form2 form結帳單 = new Form2();
            GlobalVar.formChecklist = form結帳單;
            form結帳單.Show();
            Hide();
        }
    }
}
