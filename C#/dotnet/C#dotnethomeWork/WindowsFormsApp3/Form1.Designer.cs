
namespace WindowsFormsApp3
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lboxItem = new System.Windows.Forms.ListBox();
            this.cboxSuger = new System.Windows.Forms.ComboBox();
            this.cboxIce = new System.Windows.Forms.ComboBox();
            this.cboxOther = new System.Windows.Forms.ComboBox();
            this.btnJoinOther = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrtherCount = new System.Windows.Forms.TextBox();
            this.btnOtherListView = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(272, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲店訂購單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "訂購人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(44, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "冷飲品項";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(567, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "甜度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(567, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "冰塊";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(567, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "配料";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(697, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "品項總價";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(371, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "單價";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(44, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "數量";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCount.Location = new System.Drawing.Point(135, 529);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 24);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "杯";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUnitPrice.Location = new System.Drawing.Point(355, 529);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(74, 24);
            this.lblUnitPrice.TabIndex = 0;
            this.lblUnitPrice.Text = "XXX元";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(723, 529);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(87, 24);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "XXXX元";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(48, 112);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 40);
            this.txtName.TabIndex = 1;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCount.Location = new System.Drawing.Point(49, 529);
            this.txtCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(71, 24);
            this.txtCount.TabIndex = 1;
            this.txtCount.WordWrap = false;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnJoin.Location = new System.Drawing.Point(49, 622);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(167, 54);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "加入訂購單";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnView.Location = new System.Drawing.Point(325, 622);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(167, 54);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "查看訂購單";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lboxItem
            // 
            this.lboxItem.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxItem.FormattingEnabled = true;
            this.lboxItem.ItemHeight = 17;
            this.lboxItem.Location = new System.Drawing.Point(48, 198);
            this.lboxItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxItem.Name = "lboxItem";
            this.lboxItem.Size = new System.Drawing.Size(383, 191);
            this.lboxItem.TabIndex = 3;
            this.lboxItem.SelectedIndexChanged += new System.EventHandler(this.lboxItem_SelectedIndexChanged);
            // 
            // cboxSuger
            // 
            this.cboxSuger.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxSuger.FormattingEnabled = true;
            this.cboxSuger.Location = new System.Drawing.Point(567, 200);
            this.cboxSuger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSuger.Name = "cboxSuger";
            this.cboxSuger.Size = new System.Drawing.Size(243, 28);
            this.cboxSuger.TabIndex = 4;
            this.cboxSuger.UseWaitCursor = true;
            this.cboxSuger.SelectedIndexChanged += new System.EventHandler(this.cboxSuger_SelectedIndexChanged);
            // 
            // cboxIce
            // 
            this.cboxIce.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxIce.FormattingEnabled = true;
            this.cboxIce.Location = new System.Drawing.Point(567, 266);
            this.cboxIce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxIce.Name = "cboxIce";
            this.cboxIce.Size = new System.Drawing.Size(243, 28);
            this.cboxIce.TabIndex = 4;
            this.cboxIce.SelectedIndexChanged += new System.EventHandler(this.cboxIce_SelectedIndexChanged);
            // 
            // cboxOther
            // 
            this.cboxOther.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxOther.FormattingEnabled = true;
            this.cboxOther.Location = new System.Drawing.Point(567, 332);
            this.cboxOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxOther.Name = "cboxOther";
            this.cboxOther.Size = new System.Drawing.Size(243, 28);
            this.cboxOther.TabIndex = 4;
            this.cboxOther.SelectedIndexChanged += new System.EventHandler(this.cboxOther_SelectedIndexChanged);
            // 
            // btnJoinOther
            // 
            this.btnJoinOther.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnJoinOther.Location = new System.Drawing.Point(690, 393);
            this.btnJoinOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJoinOther.Name = "btnJoinOther";
            this.btnJoinOther.Size = new System.Drawing.Size(120, 45);
            this.btnJoinOther.TabIndex = 5;
            this.btnJoinOther.Text = "加入配料";
            this.btnJoinOther.UseVisualStyleBackColor = true;
            this.btnJoinOther.Click += new System.EventHandler(this.btnJoinOther_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(187, 112);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(244, 40);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(181, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "手機號碼";
            // 
            // txtOrtherCount
            // 
            this.txtOrtherCount.Font = new System.Drawing.Font("標楷體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrtherCount.Location = new System.Drawing.Point(567, 398);
            this.txtOrtherCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrtherCount.Multiline = true;
            this.txtOrtherCount.Name = "txtOrtherCount";
            this.txtOrtherCount.Size = new System.Drawing.Size(83, 34);
            this.txtOrtherCount.TabIndex = 6;
            this.txtOrtherCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOrtherCount.TextChanged += new System.EventHandler(this.txtOrtherCount_TextChanged);
            this.txtOrtherCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrtherCount_KeyPress);
            // 
            // btnOtherListView
            // 
            this.btnOtherListView.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOtherListView.Location = new System.Drawing.Point(601, 622);
            this.btnOtherListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOtherListView.Name = "btnOtherListView";
            this.btnOtherListView.Size = new System.Drawing.Size(209, 54);
            this.btnOtherListView.TabIndex = 7;
            this.btnOtherListView.Text = "查看已加購配料";
            this.btnOtherListView.UseVisualStyleBackColor = true;
            this.btnOtherListView.Click += new System.EventHandler(this.btnOtherListView_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(567, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "配料數量";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 738);
            this.Controls.Add(this.btnOtherListView);
            this.Controls.Add(this.txtOrtherCount);
            this.Controls.Add(this.btnJoinOther);
            this.Controls.Add(this.cboxOther);
            this.Controls.Add(this.cboxIce);
            this.Controls.Add(this.cboxSuger);
            this.Controls.Add(this.lboxItem);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "冷飲店訂購單";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListBox lboxItem;
        private System.Windows.Forms.ComboBox cboxSuger;
        private System.Windows.Forms.ComboBox cboxIce;
        private System.Windows.Forms.ComboBox cboxOther;
        private System.Windows.Forms.Button btnJoinOther;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrtherCount;
        private System.Windows.Forms.Button btnOtherListView;
        private System.Windows.Forms.Label label11;
    }
}

