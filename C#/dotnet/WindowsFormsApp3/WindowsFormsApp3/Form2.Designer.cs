
namespace WindowsFormsApp3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderUser = new System.Windows.Forms.Label();
            this.lboxSelectedItem = new System.Windows.Forms.ListBox();
            this.lblTotalPayPrice = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTax = new System.Windows.Forms.CheckBox();
            this.radioDiscount1 = new System.Windows.Forms.RadioButton();
            this.radioDiscount2 = new System.Windows.Forms.RadioButton();
            this.radioDiscount3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveTxt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(137, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲訂購品項列表";
            // 
            // lblOrderUser
            // 
            this.lblOrderUser.AutoSize = true;
            this.lblOrderUser.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderUser.Location = new System.Drawing.Point(391, 87);
            this.lblOrderUser.Name = "lblOrderUser";
            this.lblOrderUser.Size = new System.Drawing.Size(114, 20);
            this.lblOrderUser.TabIndex = 0;
            this.lblOrderUser.Text = "訂購人資料";
            // 
            // lboxSelectedItem
            // 
            this.lboxSelectedItem.Font = new System.Drawing.Font("華康魏碑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxSelectedItem.FormattingEnabled = true;
            this.lboxSelectedItem.ItemHeight = 20;
            this.lboxSelectedItem.Location = new System.Drawing.Point(44, 130);
            this.lboxSelectedItem.Name = "lboxSelectedItem";
            this.lboxSelectedItem.Size = new System.Drawing.Size(461, 224);
            this.lboxSelectedItem.TabIndex = 1;
            this.lboxSelectedItem.SelectedIndexChanged += new System.EventHandler(this.lboxSelectedItem_SelectedIndexChanged);
            // 
            // lblTotalPayPrice
            // 
            this.lblTotalPayPrice.AutoSize = true;
            this.lblTotalPayPrice.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPayPrice.Location = new System.Drawing.Point(420, 391);
            this.lblTotalPayPrice.Name = "lblTotalPayPrice";
            this.lblTotalPayPrice.Size = new System.Drawing.Size(85, 20);
            this.lblTotalPayPrice.TabIndex = 0;
            this.lblTotalPayPrice.Text = " XXXX元";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(44, 541);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(173, 43);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "移除所選品項\r\n";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(332, 541);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 43);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除所選品項\r\n";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(328, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "訂購總價";
            // 
            // chkTax
            // 
            this.chkTax.AutoSize = true;
            this.chkTax.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkTax.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkTax.Location = new System.Drawing.Point(379, 415);
            this.chkTax.Name = "chkTax";
            this.chkTax.Size = new System.Drawing.Size(126, 21);
            this.chkTax.TabIndex = 4;
            this.chkTax.Text = "加入5%稅金";
            this.chkTax.UseVisualStyleBackColor = true;
            this.chkTax.CheckedChanged += new System.EventHandler(this.chkTax_CheckedChanged);
            // 
            // radioDiscount1
            // 
            this.radioDiscount1.AutoSize = true;
            this.radioDiscount1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount1.Location = new System.Drawing.Point(6, 24);
            this.radioDiscount1.Name = "radioDiscount1";
            this.radioDiscount1.Size = new System.Drawing.Size(105, 21);
            this.radioDiscount1.TabIndex = 5;
            this.radioDiscount1.TabStop = true;
            this.radioDiscount1.Text = "買二送一";
            this.radioDiscount1.UseVisualStyleBackColor = true;
            this.radioDiscount1.CheckedChanged += new System.EventHandler(this.radioDiscount1_CheckedChanged);
            // 
            // radioDiscount2
            // 
            this.radioDiscount2.AutoSize = true;
            this.radioDiscount2.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount2.Location = new System.Drawing.Point(6, 51);
            this.radioDiscount2.Name = "radioDiscount2";
            this.radioDiscount2.Size = new System.Drawing.Size(105, 21);
            this.radioDiscount2.TabIndex = 5;
            this.radioDiscount2.TabStop = true;
            this.radioDiscount2.Text = "買三送一";
            this.radioDiscount2.UseVisualStyleBackColor = true;
            this.radioDiscount2.CheckedChanged += new System.EventHandler(this.radioDiscount2_CheckedChanged);
            // 
            // radioDiscount3
            // 
            this.radioDiscount3.AutoSize = true;
            this.radioDiscount3.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount3.Location = new System.Drawing.Point(6, 78);
            this.radioDiscount3.Name = "radioDiscount3";
            this.radioDiscount3.Size = new System.Drawing.Size(124, 21);
            this.radioDiscount3.TabIndex = 5;
            this.radioDiscount3.TabStop = true;
            this.radioDiscount3.Text = "第二件半價";
            this.radioDiscount3.UseVisualStyleBackColor = true;
            this.radioDiscount3.CheckedChanged += new System.EventHandler(this.radioDiscount3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDiscount2);
            this.groupBox1.Controls.Add(this.radioDiscount3);
            this.groupBox1.Controls.Add(this.radioDiscount1);
            this.groupBox1.Font = new System.Drawing.Font("華康魏碑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(44, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "折扣活動";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(44, 590);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(173, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "關閉結帳單";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveTxt
            // 
            this.btnSaveTxt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveTxt.Location = new System.Drawing.Point(332, 590);
            this.btnSaveTxt.Name = "btnSaveTxt";
            this.btnSaveTxt.Size = new System.Drawing.Size(173, 43);
            this.btnSaveTxt.TabIndex = 7;
            this.btnSaveTxt.Text = "儲存訂單txt";
            this.btnSaveTxt.UseVisualStyleBackColor = true;
            this.btnSaveTxt.Click += new System.EventHandler(this.btnSaveTxt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(547, 672);
            this.Controls.Add(this.btnSaveTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lboxSelectedItem);
            this.Controls.Add(this.lblTotalPayPrice);
            this.Controls.Add(this.lblOrderUser);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "結帳單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderUser;
        private System.Windows.Forms.ListBox lboxSelectedItem;
        private System.Windows.Forms.Label lblTotalPayPrice;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTax;
        private System.Windows.Forms.RadioButton radioDiscount1;
        private System.Windows.Forms.RadioButton radioDiscount2;
        private System.Windows.Forms.RadioButton radioDiscount3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveTxt;
    }
}