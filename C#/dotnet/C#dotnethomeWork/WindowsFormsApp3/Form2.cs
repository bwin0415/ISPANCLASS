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
    public partial class Form2 : Form
    {
        double sum = 0;
        bool isTaxSum = false;        
        int intDiscountID = 0;//折扣代碼
        int intSum = 0;
        int intSumCount = 0;
        List<int> 單價清單 = new List<int>();
        List<int> Dlist = new List<int>();
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

            getSumCount();
           
            chkTax.Checked = true;
            isTaxSum = true;
            lblOrderUser.Text = GlobalVar.userInfo;
            GlobalVar.listOrderOtherItem.Clear();
            foreach (orderDrinks 訂購品項資訊 in GlobalVar.listOrderItem)
            {               
                string 訂購品項 = 訂購品項資訊.ItemName;   
                int 單價 = 訂購品項資訊.Itemprice;
                int 品項杯數 = 訂購品項資訊.count;
                int 品項總價 = 訂購品項資訊.toTalPay;
                string 甜度 = 訂購品項資訊.sugarLevel;
                string 冰塊 = 訂購品項資訊.Icelevel;
                string 加料清單= 訂購品項資訊.str配料資訊;
                int a = 訂購品項資訊.toTalPay;
                intSum = intSum + a;
                string str單品資訊 = string.Format("{0} {1}元  "+ 加料清單 + "  {4} {5} 數量:{2}杯 總價:{3}元", 訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊);
                lboxSelectedItem.Items.Add(str單品資訊);      //lBox只能加字串

            }
            radioDiscount0.Checked = true;

            SumTotalpay(); 
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lboxSelectedItem.SelectedIndex>=0)
            {
                int selIndex = lboxSelectedItem.SelectedIndex;
                lboxSelectedItem.Items.RemoveAt(selIndex);
                GlobalVar.listOrderItem.RemoveAt(selIndex);

                SumTotalpay();

            }
            else 
            {
                MessageBox.Show("請選擇品項");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lboxSelectedItem.Items.Clear();
            GlobalVar.listOrderItem.Clear();
            SumTotalpay(0);
        }
        void SumTotalpay()
        {
            getSumCount();

            double tax = 1.05;
            double discount = 0.0;
            //Dlist = new List<int>();
           if (intDiscountID==100)
            {
               
                discount = 0;
            }
             else if (intDiscountID == 101)
            {
               
                discount = 0;
                
                Dlist.Clear();
                int count = 0;
                count = intSumCount/= 3;
                for (int i = 0; i < count; i++)
                {

                    Dlist.Add(單價清單[i]);

                }
                discount = Dlist.Sum();
                Console.WriteLine(count);
            }
            else if (intDiscountID == 102)
            {
                discount = 0;

                Dlist.Clear();
                int count = 0;
                count = intSumCount /= 4;
                for (int i = 0; i < count; i++)
                {

                    Dlist.Add(單價清單[i]);

                }
                discount = Dlist.Sum();
                Console.WriteLine(count);
            }
            else if (intDiscountID == 103)
            {
                discount = 0;

                Dlist.Clear();
                int count = 0;
                count = intSumCount /2;
                for (int i = 0; i < count; i++)
                {

                    Dlist.Add(單價清單[i]);

                }
                discount = Dlist.Sum()/2;
                Console.WriteLine(count);

            }

            //先折扣後計價
            if (isTaxSum)
            {
                sum = (intSum-discount) * tax;

            }
            else
            {
                sum = intSum-discount;
            }

            Console.WriteLine(sum);
            if (lboxSelectedItem.Items.Count>0)
            {
                lblTotalPayPrice.Text = Math.Ceiling(sum).ToString();
            }
            else
            {
                sum = 0;
                lblTotalPayPrice.Text = Math.Ceiling(sum).ToString();
            }

            
        }
        
        void SumTotalpay(int a = 0)
        {
            double sum = a ;
            lblTotalPayPrice.Text = sum.ToString();
        }

        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {

            if (chkTax.Checked==true)
            {
                isTaxSum = true;
            }
            else
            {
               
                isTaxSum = false;
            }
            SumTotalpay();
        }


        #region 加分題-折扣
        void getSumCount()
        {
            單價清單.Clear();
            intSumCount = 0;
            
            foreach (orderDrinks 訂購品項資訊 in GlobalVar.listOrderItem)
            {
                int b = 訂購品項資訊.count;
                int c = 訂購品項資訊.Itemprice;
               
                intSumCount += b;
                for (int i = 0; i < b; i++)
                {
                    單價清單.Add(c);
                }
            }
            單價清單.Sort();
        }
        private void radioDiscount0_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountID = (int)DiscountEnum.CodeID.無;

            SumTotalpay();
        }
        private void radioDiscount1_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountID = (int)DiscountEnum.CodeID.買二送一;
            SumTotalpay();
        }

        private void radioDiscount2_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountID = (int)DiscountEnum.CodeID.買三送一;
            SumTotalpay();
        }

        private void radioDiscount3_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountID = (int)DiscountEnum.CodeID.第二件半價;
            SumTotalpay();
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) //<=防止記憶體流失 memory leak 
        {
           
            GlobalVar.formMenu.Show();
        }
        
        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            string strFileAddress = @"C:\Users\BWIN\Desktop";
            Random myRnd = new Random();
            int myNum = myRnd.Next(1000,9999);
            string strFileName = DateTime.Now.ToString("yyMMddHHmmss")+myNum.ToString()+@"訂購單.txt";
            string strFile = strFileAddress + @"\" + strFileName;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = strFileAddress;
            sfd.FileName = strFileName;
            sfd.Filter = "Text File|*.txt";

            DialogResult R = sfd.ShowDialog();
            if (R==DialogResult.OK)
            {
                strFile = sfd.FileName;
            }else
            {
                return;
            }
            //////////////訂購單存檔訂購單存檔
            List<string> listOrderInfo = new List<string>();
            listOrderInfo.Add("****************冷飲訂單**************");
            listOrderInfo.Add("--------------------------------------");
            listOrderInfo.Add("訂購時間："+DateTime.Now.ToString()+"訂購人："+GlobalVar.userInfo);
            listOrderInfo.Add("--------------------------------------");
            foreach (orderDrinks 訂購品項資訊 in GlobalVar.listOrderItem)
            {//這裡是區域變數list
             //要和ArrayList順序一樣 因為有索引值問題
                string 訂購品項 = 訂購品項資訊.ItemName;
                int 單價 = 訂購品項資訊.Itemprice;
                int 品項杯數 = 訂購品項資訊.count;
                int 品項總價 = 訂購品項資訊.toTalPay;
                string 甜度 = 訂購品項資訊.sugarLevel;
                string 冰塊 = 訂購品項資訊.Icelevel;
                string 加料清單 = 訂購品項資訊.str配料資訊;
                string str單品資訊 = string.Format("{0} {1}元  " + 加料清單 + "  {4} {5} 數量:{2}杯 總價:{3}元", 訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊);
                listOrderInfo.Add(str單品資訊);      //lBox只能加字串

            }
            listOrderInfo.Add("--------------------------------------");
            listOrderInfo.Add("總價："+ sum);
            listOrderInfo.Add("*****************謝謝光臨**************");

            System.IO.File.WriteAllLines(strFile, listOrderInfo, Encoding.UTF8);
            MessageBox.Show("存檔成功");

        }


    }
}
