
namespace WindowsFormsApp1
{
    partial class 結帳
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFlieghtNO = new System.Windows.Forms.TextBox();
            this.txtCusmorId = new System.Windows.Forms.TextBox();
            this.btnCustorIdCheck = new System.Windows.Forms.Button();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.dtpA = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCusmorPhone = new System.Windows.Forms.TextBox();
            this.mtxtPwd = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.btnSearchFlieghtNo = new System.Windows.Forms.Button();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lBoxOrder = new System.Windows.Forms.ListBox();
            this.btnCheckFlieght = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "員工編號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "員工密碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "航班代號";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(17, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "航班日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(17, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "客戶身分證";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtId.Location = new System.Drawing.Point(109, 44);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(137, 28);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtFlieghtNO
            // 
            this.txtFlieghtNO.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFlieghtNO.Location = new System.Drawing.Point(107, 166);
            this.txtFlieghtNO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFlieghtNO.Name = "txtFlieghtNO";
            this.txtFlieghtNO.Size = new System.Drawing.Size(137, 28);
            this.txtFlieghtNO.TabIndex = 1;
            // 
            // txtCusmorId
            // 
            this.txtCusmorId.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCusmorId.Location = new System.Drawing.Point(128, 286);
            this.txtCusmorId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCusmorId.Name = "txtCusmorId";
            this.txtCusmorId.Size = new System.Drawing.Size(137, 28);
            this.txtCusmorId.TabIndex = 1;
            this.txtCusmorId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusmorId_KeyPress);
            // 
            // btnCustorIdCheck
            // 
            this.btnCustorIdCheck.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCustorIdCheck.Location = new System.Drawing.Point(283, 283);
            this.btnCustorIdCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustorIdCheck.Name = "btnCustorIdCheck";
            this.btnCustorIdCheck.Size = new System.Drawing.Size(104, 31);
            this.btnCustorIdCheck.TabIndex = 3;
            this.btnCustorIdCheck.Text = "驗證";
            this.btnCustorIdCheck.UseVisualStyleBackColor = true;
            this.btnCustorIdCheck.Visible = false;
            this.btnCustorIdCheck.Click += new System.EventHandler(this.btnCustorIdCheck_Click);
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPay.Location = new System.Drawing.Point(994, 328);
            this.lblTotalPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(46, 17);
            this.lblTotalPay.TabIndex = 0;
            this.lblTotalPay.Text = "總價";
            this.lblTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpA
            // 
            this.dtpA.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpA.Location = new System.Drawing.Point(107, 227);
            this.dtpA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpA.Name = "dtpA";
            this.dtpA.Size = new System.Drawing.Size(167, 28);
            this.dtpA.TabIndex = 4;
            this.dtpA.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(17, 331);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "手機";
            // 
            // txtCusmorPhone
            // 
            this.txtCusmorPhone.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCusmorPhone.Location = new System.Drawing.Point(128, 328);
            this.txtCusmorPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCusmorPhone.Name = "txtCusmorPhone";
            this.txtCusmorPhone.Size = new System.Drawing.Size(137, 28);
            this.txtCusmorPhone.TabIndex = 1;
            this.txtCusmorPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusmorPhone_KeyPress);
            // 
            // mtxtPwd
            // 
            this.mtxtPwd.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mtxtPwd.Location = new System.Drawing.Point(107, 105);
            this.mtxtPwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtxtPwd.Name = "mtxtPwd";
            this.mtxtPwd.PasswordChar = '*';
            this.mtxtPwd.Size = new System.Drawing.Size(137, 28);
            this.mtxtPwd.TabIndex = 5;
            this.mtxtPwd.TextChanged += new System.EventHandler(this.mtxtPwd_TextChanged);
            this.mtxtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPwd_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(254, 47);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "員工姓名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProductSearch);
            this.groupBox1.Controls.Add(this.btnSearchFlieghtNo);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(20, 395);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(367, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "員工資料及商品資料查詢";
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductSearch.Location = new System.Drawing.Point(17, 42);
            this.btnProductSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(119, 42);
            this.btnProductSearch.TabIndex = 3;
            this.btnProductSearch.Text = "產品管理";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // btnSearchFlieghtNo
            // 
            this.btnSearchFlieghtNo.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchFlieghtNo.Location = new System.Drawing.Point(175, 42);
            this.btnSearchFlieghtNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchFlieghtNo.Name = "btnSearchFlieghtNo";
            this.btnSearchFlieghtNo.Size = new System.Drawing.Size(143, 42);
            this.btnSearchFlieghtNo.TabIndex = 3;
            this.btnSearchFlieghtNo.Text = "航班代碼查詢";
            this.btnSearchFlieghtNo.UseVisualStyleBackColor = true;
            this.btnSearchFlieghtNo.Click += new System.EventHandler(this.btnSearchFlieghtNo_Click);
            // 
            // btnClearItem
            // 
            this.btnClearItem.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearItem.Location = new System.Drawing.Point(200, 90);
            this.btnClearItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(119, 52);
            this.btnClearItem.TabIndex = 3;
            this.btnClearItem.Text = "清除所有品項";
            this.btnClearItem.UseVisualStyleBackColor = true;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveAt.Location = new System.Drawing.Point(17, 90);
            this.btnRemoveAt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(119, 52);
            this.btnRemoveAt.TabIndex = 3;
            this.btnRemoveAt.Text = "刪除品項";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOutput.Location = new System.Drawing.Point(200, 23);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(119, 52);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "結帳";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.Location = new System.Drawing.Point(17, 23);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 52);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "取消結帳";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReturn);
            this.groupBox2.Controls.Add(this.btnOutput);
            this.groupBox2.Controls.Add(this.btnRemoveAt);
            this.groupBox2.Controls.Add(this.btnClearItem);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(611, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(367, 160);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "POS功能";
            // 
            // lBoxOrder
            // 
            this.lBoxOrder.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBoxOrder.FormattingEnabled = true;
            this.lBoxOrder.ItemHeight = 17;
            this.lBoxOrder.Location = new System.Drawing.Point(628, 44);
            this.lBoxOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lBoxOrder.Name = "lBoxOrder";
            this.lBoxOrder.Size = new System.Drawing.Size(538, 276);
            this.lBoxOrder.TabIndex = 2;
            // 
            // btnCheckFlieght
            // 
            this.btnCheckFlieght.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckFlieght.Location = new System.Drawing.Point(266, 169);
            this.btnCheckFlieght.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCheckFlieght.Name = "btnCheckFlieght";
            this.btnCheckFlieght.Size = new System.Drawing.Size(104, 31);
            this.btnCheckFlieght.TabIndex = 3;
            this.btnCheckFlieght.Text = "驗證";
            this.btnCheckFlieght.UseVisualStyleBackColor = true;
            this.btnCheckFlieght.Visible = false;
            this.btnCheckFlieght.Click += new System.EventHandler(this.btnCheckFlieght_Click);
            // 
            // 結帳
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1242, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtxtPwd);
            this.Controls.Add(this.dtpA);
            this.Controls.Add(this.btnCheckFlieght);
            this.Controls.Add(this.btnCustorIdCheck);
            this.Controls.Add(this.lBoxOrder);
            this.Controls.Add(this.txtCusmorPhone);
            this.Controls.Add(this.txtCusmorId);
            this.Controls.Add(this.txtFlieghtNO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "結帳";
            this.Text = "結帳";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.結帳_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFlieghtNO;
        private System.Windows.Forms.TextBox txtCusmorId;
        private System.Windows.Forms.Button btnCustorIdCheck;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.DateTimePicker dtpA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCusmorPhone;
        private System.Windows.Forms.MaskedTextBox mtxtPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lBoxOrder;
        private System.Windows.Forms.Button btnCheckFlieght;
        private System.Windows.Forms.Button btnSearchFlieghtNo;
    }
}

