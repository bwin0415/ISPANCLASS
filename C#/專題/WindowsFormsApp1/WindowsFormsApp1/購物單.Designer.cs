
namespace WindowsFormsApp1
{
    partial class 購物單
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnAddCashierList = new System.Windows.Forms.Button();
            this.btnRemoveSelectedItem = new System.Windows.Forms.Button();
            this.btnRemoveALL = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(70, 64);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(563, 507);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddCashierList
            // 
            this.btnAddCashierList.Location = new System.Drawing.Point(707, 115);
            this.btnAddCashierList.Name = "btnAddCashierList";
            this.btnAddCashierList.Size = new System.Drawing.Size(147, 42);
            this.btnAddCashierList.TabIndex = 2;
            this.btnAddCashierList.Text = "加入購物清單";
            this.btnAddCashierList.UseVisualStyleBackColor = true;
            this.btnAddCashierList.Click += new System.EventHandler(this.btnAddCashierList_Click);
            // 
            // btnRemoveSelectedItem
            // 
            this.btnRemoveSelectedItem.Location = new System.Drawing.Point(707, 208);
            this.btnRemoveSelectedItem.Name = "btnRemoveSelectedItem";
            this.btnRemoveSelectedItem.Size = new System.Drawing.Size(147, 39);
            this.btnRemoveSelectedItem.TabIndex = 2;
            this.btnRemoveSelectedItem.Text = "移除所選商品";
            this.btnRemoveSelectedItem.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedItem.Click += new System.EventHandler(this.btnRemoveSelectedItem_Click);
            // 
            // btnRemoveALL
            // 
            this.btnRemoveALL.Location = new System.Drawing.Point(707, 298);
            this.btnRemoveALL.Name = "btnRemoveALL";
            this.btnRemoveALL.Size = new System.Drawing.Size(147, 42);
            this.btnRemoveALL.TabIndex = 2;
            this.btnRemoveALL.Text = "移除所有商品";
            this.btnRemoveALL.UseVisualStyleBackColor = true;
            this.btnRemoveALL.Click += new System.EventHandler(this.btnRemoveALL_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSum.Location = new System.Drawing.Point(1272, 544);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(70, 27);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "總價";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(1060, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 27);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "會員姓名";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(942, 115);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(563, 411);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(707, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "結束購物";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Location = new System.Drawing.Point(707, 391);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(147, 42);
            this.btnCashier.TabIndex = 2;
            this.btnCashier.Text = "結  帳";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "商品列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(938, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "購物車";
            // 
            // 購物單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 660);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveALL);
            this.Controls.Add(this.btnRemoveSelectedItem);
            this.Controls.Add(this.btnAddCashierList);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "購物單";
            this.Text = "客戶選購商品";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.購物單_FormClosed);
            this.Load += new System.EventHandler(this.購物單_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCashierList;
        private System.Windows.Forms.Button btnRemoveSelectedItem;
        private System.Windows.Forms.Button btnRemoveALL;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}