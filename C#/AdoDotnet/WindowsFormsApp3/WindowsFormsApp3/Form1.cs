using System;
using System.Collections.Generic;
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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();//基本欄位檢查沒鳥用還是得用自己寫的
            this.personsBindingSource.EndEdit();//結束編輯模式
            this.tableAdapterManager.UpdateAll(this.myDbDataSet);//(myDb)DataSet (會隨資料庫變成不一樣)資料集  UpdateAll不要用浪費效能


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myDbDataSet.Persons' 資料表。您可以視需要進行移動或移除。
            this.personsTableAdapter.Fill(this.myDbDataSet.Persons);
            cBoxFind.Items.Add("姓名");
            cBoxFind.Items.Add("電話");
            cBoxFind.Items.Add("地址");
            cBoxFind.Items.Add("Email");
            cBoxFind.SelectedIndex=0;
            cBoxFilter.Items.Add("姓名");
            cBoxFilter.Items.Add("電話");
            cBoxFilter.Items.Add("地址");
            cBoxFilter.Items.Add("Email");
            cBoxFilter.SelectedIndex=0;
            Page();
        }

        private void btnFirstData_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveFirst();
            Page();
        }

        private void btnLastData_Click(object sender, EventArgs e)
        {
            personsBindingSource.MovePrevious();
            Page();
        }

        private void btnNextData_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveNext();
            Page();
        }

        private void btnFinData_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveLast();
            Page();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要刪除此筆資料?", "刪除確認", MessageBoxButtons.YesNo); //檔案選擇對話框
            if (R == DialogResult.Yes)
            {//yes 
                #region   UI介面刪除
                personsBindingSource.EndEdit();//關閉編輯模式
                int idxCurrent = personsBindingSource.Position;
                personsBindingSource.RemoveAt(idxCurrent);
                #endregion

                personsTableAdapter.Update(myDbDataSet.Persons);//更新資料庫內容

                personsBindingSource.Position = 0;

                Page();
                MessageBox.Show("資料刪除成功");
            }
            else
            {//no

            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要回復資料嗎","資料回復",MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {
                personsBindingSource.EndEdit();
                int idxCurrent = personsBindingSource.Position;
                personsTableAdapter.Fill(myDbDataSet.Persons);
                personsBindingSource.Position = idxCurrent;
                Page();
                MessageBox.Show("資料回復成功");
            }
            else
            {

            }
        }

        private void btnNewData_Click(object sender, EventArgs e)//清空欄位,進入新增模式。
        {
            personsBindingSource.AddNew();
            dtpBirthday.Value = new DateTime(1900,1,1,0,0,0);
            chkMarriage.Checked = false;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            Save();
        }

        void Page() 
        {
            int Nowpage = personsBindingSource.Position + 1;
            lblPage.Text = "第" + Nowpage + "筆" + "/" + "共" + personsBindingSource.Count + "筆";
        }
        void Save() 
        {
            DialogResult R = MessageBox.Show("您確認要儲存?", "儲存確認", MessageBoxButtons.YesNo); //檔案選擇對話框
            if (R == DialogResult.Yes)
            {//yes 儲存
             // 未來工作時，要做欄位檢查
                this.Validate();//基本欄位檢查沒鳥用還是得用自己寫的
                this.personsBindingSource.EndEdit();//結束編輯模式
                personsTableAdapter.Update(myDbDataSet.Persons);//(myDb)DataSet (會隨資料庫變成不一樣)資料集  UpdateAll不要用浪費效能
                Page();
                MessageBox.Show("資料儲存成功");
            }
            else
            {//no

            }

        }

        private void btnFind_Click(object sender, EventArgs e) //Find 只會精確地找到一筆 
        {
            if (txtFind.Text!="")
            {
                string strSearch = txtFind.Text;
                string strFieldName = cBoxFind.SelectedItem.ToString();
                int idxFind = personsBindingSource.Find(strFieldName, strSearch);
                if (idxFind >= 0)
                {
                    personsBindingSource.Position = idxFind;
                }
                else 
                {
                    MessageBox.Show("找不到資料");
                }
            }
            else 
            {
                //找不到是-1
                MessageBox.Show("請輸入Find關鍵字搜尋");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text != "")
            {
                string strSearch = txtFilter.Text;
                string strFieldName = cBoxFilter.SelectedItem.ToString();
                personsBindingSource.Filter = string.Format("{0} like '%{1}%'",strFieldName,strSearch);//裡面是SQL語法where的右邊 

            }
            else
            {
                MessageBox.Show("請輸入Filter關鍵字搜尋");
            }
        }

        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            personsBindingSource.RemoveFilter();
            txtFilter.Clear();
            MessageBox.Show("條件移除");

        }
    }
    
}
