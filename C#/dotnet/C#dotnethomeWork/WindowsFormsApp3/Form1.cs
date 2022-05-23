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
        drinkItem[] drink = new drinkItem[12];
        Others[] others = new Others[6];


        List<string> listSugar = new List<string>();
        List<string> listIce = new List<string>();
       
        //作業規格：加料價錢
        int itemCount = 0, uniPrice = 0, totalPay = 0, itemOtherPrice = 0,otherCount =0;
        string itemName = "", itemSugar = "", itemIce = "", itemOtherName = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            #region 飲料
            drink[0] = new drinkItem("紅茶", 20);
            drink[1] = new drinkItem("綠茶", 20);
            drink[2] = new drinkItem("烏龍茶", 20);
            drink[3] = new drinkItem("麥茶", 25);
            drink[4] = new drinkItem("奶茶", 40);
            drink[5] = new drinkItem("冬瓜茶", 25);
            drink[6] = new drinkItem("豆漿紅茶", 40);
            drink[7] = new drinkItem("豆漿綠茶", 40);
            drink[8] = new drinkItem("蜂蜜紅茶", 35);
            drink[9] = new drinkItem("蜂蜜綠茶", 35);
            drink[10] = new drinkItem("蜂蜜奶茶", 45);
            drink[11] = new drinkItem("蜂蜜紅龍茶", 35);

            for (int i = 0; i < drink.Length; i++)
            {
                lboxItem.Items.Add(drink[i].ItemName);
            }
            #endregion

            #region 配料
            others[0] = new Others("珍珠", 5);
            others[1] = new Others("波霸", 5);
            others[2] = new Others("西米露", 5);
            others[3] = new Others("布丁", 15);
            others[4] = new Others("仙草凍", 10);
            others[5] = new Others("綠茶凍", 10);
            for (int i = 0; i < others.Length; i++)
            {
                cboxOther.Items.Add(others[i].othername + "  " + @"$" + others[i].otherPrice);
            }
            #endregion




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
            listSugar.Add("無糖");
            foreach (string itemname in listSugar)
            {
                cboxSuger.Items.Add(itemname);
            }
            cboxSuger.SelectedIndex = 0;
            #endregion 
            #region 冰塊
            listIce.Add("正常");
            listIce.Add("少冰");
            listIce.Add("半冰");
            listIce.Add("微冰");
            listIce.Add("去冰");
            foreach (string itemname in listIce)
            {
                cboxIce.Items.Add(itemname);
            }
            cboxIce.SelectedIndex = 0;
            #endregion
            lblUnitPrice.Text = "0元";


        }

        private void lboxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int selIndex = lboxItem.SelectedIndex;
            GlobalVar.listOrderOtherItem.Clear();
            itemName = drink[selIndex].ItemName;
            uniPrice = drink[selIndex].Itemprice;
            cboxOther.Text = "";
            lblUnitPrice.Text = uniPrice.ToString() + "元";
            totalPay = GetOthersPrice() * itemCount;
            lblTotalPrice.Text = totalPay.ToString() + "元";
            

        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)//杯數 只能數字
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
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
            int selIndex = cboxIce.SelectedIndex;
            itemIce = listIce[selIndex];
        }

        private void cboxOther_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cboxOther.SelectedIndex;
            itemOtherName = others[selIndex].othername;
            itemOtherPrice = others[selIndex].otherPrice;
            if (cboxOther.Text!="")
            {
                txtOrtherCount.Text = "1";
            }
            totalPay = itemCount * GetOthersPrice();
            lblTotalPrice.Text = totalPay.ToString() + "元";


        }
        



        int GetOthersPrice ( )
        {
            int price =0;
            if (cboxOther.Text!=""&& GlobalVar.listOrderOtherItem.Count <=1)
            {
                price = uniPrice + (itemOtherPrice*otherCount);
                return price;
            }
            else if(GlobalVar.listOrderOtherItem.Count>1)
            {
                int sum = 0;
                foreach (OtherList Ol in GlobalVar.listOrderOtherItem)
                {
                    int a = Ol.toTal;
                     
                    sum += a;
                }
              
                  price = uniPrice + sum;
                
               
                return price;
            }
            else
            {
                price = uniPrice;
                return price;
            }
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
                   

        
                try
                {
                    itemCount = Convert.ToInt32(txtCount.Text);
                    totalPay =  itemCount * (GetOthersPrice());
                    lblTotalPrice.Text = totalPay.ToString() + "元";
                    //作業規格：杯數避免與改正輸入錯誤
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString(), "字串為空值");
                }
            
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text!=""&&txtPhone.Text.Length == 10)
            {


                List<OtherList> add = GlobalVar.listOrderOtherItem;
                orderDrinks itemOrderInfo = new orderDrinks(itemName, uniPrice, itemCount,itemSugar, itemIce, add);//作業要用自訂類別
                GlobalVar.listOrderItem.Add(itemOrderInfo);
                GlobalVar.userInfo = txtName.Text+txtPhone.Text;
                MessageBox.Show("已加入結帳單" + string.Format("{0}", itemOrderInfo.ToString()));
                
            }
            else if(txtPhone.Text.Length != 10)
            {
                MessageBox.Show("請正確輸入手機號碼");
            }
            else if(txtName.Text != "")
            {
                MessageBox.Show("請正確輸入聯絡人姓名");
            }
   

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (GlobalVar.listOrderItem.Count==0)
            {
                MessageBox.Show("裡面沒有任何訂單");
            }
            else
            {
                GlobalVar.userInfo = txtName.Text + txtPhone.Text;
                GlobalVar.formMenu = this;
                Form2 form結帳單 = new Form2();
                GlobalVar.formChecklist = form結帳單;
                form結帳單.Show();
                Hide();
            }

        }
        #region 複選配料(完成)
        private void txtOrtherCount_TextChanged(object sender, EventArgs e)
        {

            try
            {
                otherCount = Convert.ToInt32(txtOrtherCount.Text);

                totalPay = itemCount * (GetOthersPrice());
                lblTotalPrice.Text = totalPay.ToString() + "元";
                //作業規格：杯數避免與改正輸入錯誤
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString(), "字串為空值");
            }

        }
        private void btnJoinOther_Click(object sender, EventArgs e)
        {
            if (cboxOther.Text == "")
            {
                MessageBox.Show("請選擇配料");
            }
            else
            {

                OtherList Ol = new OtherList(itemOtherName, itemOtherPrice, otherCount);
                bool istheSame = false;
                if (GlobalVar.listOrderOtherItem.Count == 0)
                {
                    GlobalVar.listOrderOtherItem.Add(Ol);
                }
                else if (GlobalVar.listOrderOtherItem.Count > 0)
                {
                    int ii = 0;
                    ; for (int i = 0; i < GlobalVar.listOrderOtherItem.Count; i++)
                    {
                        if (GlobalVar.listOrderOtherItem[i].othername == Ol.othername)
                        {

                            istheSame = true;
                            ii = i;
                            break;

                        }

                    }
                    if (istheSame)
                    {
                        GlobalVar.listOrderOtherItem[ii].count += Ol.count;
                        GlobalVar.listOrderOtherItem[ii].toTal += Ol.toTal;

                    }
                    else
                    {
                        GlobalVar.listOrderOtherItem.Add(Ol);

                    }
                }
                MessageBox.Show(string.Format("{0} {2}份 共{1}元", Ol.othername, (Ol.otherPrice * Ol.count).ToString(), Ol.count.ToString()));
                totalPay = itemCount * (GetOthersPrice());
                lblTotalPrice.Text = totalPay.ToString() + "元";
            }




        }

        string 配料資訊="";
        private void btnOtherListView_Click(object sender, EventArgs e)
        {
            string 配料名稱;
            int 配料價格;
            int 配料數量;
            配料資訊 = "";
            foreach (OtherList oL in GlobalVar.listOrderOtherItem)
            {
                配料名稱 = oL.othername;
                配料價格 = oL.otherPrice;
                配料數量 = oL.count;

                配料資訊 += string.Format("配料：{0} 價錢：{1} 數量：{2}\n", 配料名稱, 配料價格, 配料數量);

            }

            MessageBox.Show(配料資訊);
        }

        private void txtOrtherCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion 


    }
}
