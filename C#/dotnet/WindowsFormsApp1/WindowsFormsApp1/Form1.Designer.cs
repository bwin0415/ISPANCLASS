
namespace WindowsFormsApp1
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
            this.btn_memberCreate2 = new System.Windows.Forms.Button();
            this.btn_memberCreate1 = new System.Windows.Forms.Button();
            this.btn_AllStuff = new System.Windows.Forms.Button();
            this.btn_ManagerCreater = new System.Windows.Forms.Button();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_memberCreate2
            // 
            this.btn_memberCreate2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_memberCreate2.Location = new System.Drawing.Point(167, 253);
            this.btn_memberCreate2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_memberCreate2.Name = "btn_memberCreate2";
            this.btn_memberCreate2.Size = new System.Drawing.Size(265, 86);
            this.btn_memberCreate2.TabIndex = 0;
            this.btn_memberCreate2.Text = "創建員工2";
            this.btn_memberCreate2.UseVisualStyleBackColor = true;
            this.btn_memberCreate2.Click += new System.EventHandler(this.btn_memberCreate2_Click);
            // 
            // btn_memberCreate1
            // 
            this.btn_memberCreate1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_memberCreate1.Location = new System.Drawing.Point(167, 115);
            this.btn_memberCreate1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_memberCreate1.Name = "btn_memberCreate1";
            this.btn_memberCreate1.Size = new System.Drawing.Size(265, 86);
            this.btn_memberCreate1.TabIndex = 0;
            this.btn_memberCreate1.Text = "創建員工1";
            this.btn_memberCreate1.UseVisualStyleBackColor = true;
            this.btn_memberCreate1.Click += new System.EventHandler(this.btn_memberCreate1_Click);
            // 
            // btn_AllStuff
            // 
            this.btn_AllStuff.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AllStuff.Location = new System.Drawing.Point(167, 402);
            this.btn_AllStuff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AllStuff.Name = "btn_AllStuff";
            this.btn_AllStuff.Size = new System.Drawing.Size(265, 86);
            this.btn_AllStuff.TabIndex = 0;
            this.btn_AllStuff.Text = "列出所有員工";
            this.btn_AllStuff.UseVisualStyleBackColor = true;
            this.btn_AllStuff.Click += new System.EventHandler(this.btn_AllStuff_Click);
            // 
            // btn_ManagerCreater
            // 
            this.btn_ManagerCreater.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ManagerCreater.Location = new System.Drawing.Point(167, 559);
            this.btn_ManagerCreater.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ManagerCreater.Name = "btn_ManagerCreater";
            this.btn_ManagerCreater.Size = new System.Drawing.Size(265, 86);
            this.btn_ManagerCreater.TabIndex = 0;
            this.btn_ManagerCreater.Text = "創建管理者1";
            this.btn_ManagerCreater.UseVisualStyleBackColor = true;
            this.btn_ManagerCreater.Click += new System.EventHandler(this.btn_ManagerCreater_Click);
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoginName.Location = new System.Drawing.Point(350, 34);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(88, 24);
            this.lblLoginName.TabIndex = 1;
            this.lblLoginName.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 868);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.btn_memberCreate1);
            this.Controls.Add(this.btn_ManagerCreater);
            this.Controls.Add(this.btn_AllStuff);
            this.Controls.Add(this.btn_memberCreate2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Class實作";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_memberCreate2;
        private System.Windows.Forms.Button btn_memberCreate1;
        private System.Windows.Forms.Button btn_AllStuff;
        private System.Windows.Forms.Button btn_ManagerCreater;
        private System.Windows.Forms.Label lblLoginName;
    }
}

