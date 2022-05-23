
namespace HomeWork
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
            this.CHKBL_1 = new System.Windows.Forms.CheckedListBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_Autochoose = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.CHKBL_2 = new System.Windows.Forms.CheckedListBox();
            this.lblwinnum = new System.Windows.Forms.Label();
            this.lblwinnmsort = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(154, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "威力彩";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "第一區";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(25, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "第二區";
            // 
            // CHKBL_1
            // 
            this.CHKBL_1.CheckOnClick = true;
            this.CHKBL_1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CHKBL_1.FormattingEnabled = true;
            this.CHKBL_1.Location = new System.Drawing.Point(28, 135);
            this.CHKBL_1.Margin = new System.Windows.Forms.Padding(2);
            this.CHKBL_1.Name = "CHKBL_1";
            this.CHKBL_1.Size = new System.Drawing.Size(468, 136);
            this.CHKBL_1.TabIndex = 2;
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_check.Location = new System.Drawing.Point(70, 521);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(139, 33);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "對    獎";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_Autochoose
            // 
            this.btn_Autochoose.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Autochoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Autochoose.Location = new System.Drawing.Point(70, 584);
            this.btn_Autochoose.Name = "btn_Autochoose";
            this.btn_Autochoose.Size = new System.Drawing.Size(139, 33);
            this.btn_Autochoose.TabIndex = 1;
            this.btn_Autochoose.Text = "電  腦  選  號";
            this.btn_Autochoose.UseVisualStyleBackColor = true;
            this.btn_Autochoose.Click += new System.EventHandler(this.btn_Autochoose_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.Location = new System.Drawing.Point(272, 521);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(139, 33);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "清    除";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_end.Location = new System.Drawing.Point(272, 584);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(139, 33);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "結    束";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // CHKBL_2
            // 
            this.CHKBL_2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CHKBL_2.FormattingEnabled = true;
            this.CHKBL_2.Location = new System.Drawing.Point(28, 332);
            this.CHKBL_2.Margin = new System.Windows.Forms.Padding(2);
            this.CHKBL_2.Name = "CHKBL_2";
            this.CHKBL_2.Size = new System.Drawing.Size(468, 26);
            this.CHKBL_2.TabIndex = 2;
            // 
            // lblwinnum
            // 
            this.lblwinnum.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblwinnum.Location = new System.Drawing.Point(26, 396);
            this.lblwinnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwinnum.Name = "lblwinnum";
            this.lblwinnum.Size = new System.Drawing.Size(470, 52);
            this.lblwinnum.TabIndex = 3;
            this.lblwinnum.Text = "label4";
            // 
            // lblwinnmsort
            // 
            this.lblwinnmsort.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblwinnmsort.Location = new System.Drawing.Point(26, 448);
            this.lblwinnmsort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwinnmsort.Name = "lblwinnmsort";
            this.lblwinnmsort.Size = new System.Drawing.Size(470, 57);
            this.lblwinnmsort.TabIndex = 3;
            this.lblwinnmsort.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblwinnmsort);
            this.panel1.Controls.Add(this.lblwinnum);
            this.panel1.Controls.Add(this.CHKBL_2);
            this.panel1.Controls.Add(this.btn_end);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_Autochoose);
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.CHKBL_1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 637);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 776);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox CHKBL_1;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_Autochoose;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.CheckedListBox CHKBL_2;
        private System.Windows.Forms.Label lblwinnum;
        private System.Windows.Forms.Label lblwinnmsort;
        private System.Windows.Forms.Panel panel1;
    }
}

