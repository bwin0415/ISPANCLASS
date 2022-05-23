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
        bool isTaxSum = false;        
        int intDiscountID = 0;//折扣代碼
        int intSum = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chkTax.Checked = true;
            isTaxSum = true;
            lblOrderUser.Text = GlobalVar.userInfo;

            foreach (ArrayList 訂購品項資訊 in GlobalVar.listOrderItem)
            {//這裡是區域變數list
             //要和ArrayList順序一樣 因為有索引值問題
                string 訂購品項 = (string)(訂購品項資訊[0]);   //Convert.ToString(訂購品項資訊[0]);  
                int 單價 = (int)(訂購品項資訊[1]);
                int 品項杯數 = (int)(訂購品項資訊[2]);
                int 品項總價 = (int)(訂購品項資訊[3]);
                string 甜度 = (string)(訂購品項資訊[4]);
                string 冰塊 = (string)(訂購品項資訊[5]);
                string 加料 = (string)(訂購品項資訊[6]);
                int 加料價格 = (int)(訂購品項資訊[7]);

                string str單品資訊 = string.Format("{0} {1}元 數量:{2}杯 總價:{3}元 {4} {5} {6} {7}元", 訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊, 加料, 加料價格);

                lboxSelectedItem.Items.Add(str單品資訊);      //lBox只能加字串

            }
            SumTotalpay(); 
        }

        private void lboxSelectedItem_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            SumTotalpay();
        }
        void SumTotalpay()
        {

            double sum=0;
            double tax = 0.05;
            if (isTaxSum)
            {
                sum = 1000*tax;

            }
            else
            {
                sum = 1000;
            }
        }

        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTax.Checked==true)
            {
                MessageBox.Show("計算稅金");
                isTaxSum = true;
            }
            else
            {
                MessageBox.Show("不計算稅金");
                isTaxSum = false;
            }
            SumTotalpay();
        }


        #region 加分題-折扣
        private void radioDiscount1_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountID = 101;
            SumTotalpay();
        }

        private void radioDiscount2_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountID = 102;
            SumTotalpay();
        }

        private void radioDiscount3_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountID = 103;
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
            foreach (ArrayList 訂購品項資訊 in GlobalVar.listOrderItem)
            {//這裡是區域變數list
             //要和ArrayList順序一樣 因為有索引值問題
                string 訂購品項 = (string)(訂購品項資訊[0]);   //Convert.ToString(訂購品項資訊[0]);  
                int 單價 = (int)(訂購品項資訊[1]);
                int 品項杯數 = (int)(訂購品項資訊[2]);
                int 品項總價 = (int)(訂購品項資訊[3]);
                string 甜度 = (string)(訂購品項資訊[4]);
                string 冰塊 = (string)(訂購品項資訊[5]);
                string 加料 = (string)(訂購品項資訊[6]);
                int 加料價格 = (int)(訂購品項資訊[7]);

                string str單品資訊 = string.Format("{0} {1}元 數量:{2}杯 總價:{3}元 {4} {5} {6} {7}元", 訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊, 加料, 加料價格);

                listOrderInfo.Add(str單品資訊);      //lBox只能加字串

            }
            listOrderInfo.Add("--------------------------------------");
            listOrderInfo.Add("總價："+intSum);
            listOrderInfo.Add("*****************謝謝光臨**************");

            System.IO.File.WriteAllLines(strFile, listOrderInfo, Encoding.UTF8);
            MessageBox.Show("存檔成功");

        }
    }
}
