
namespace WindowsFormsApp4
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
            this.lbl_V1 = new System.Windows.Forms.Label();
            this.lbl_V2 = new System.Windows.Forms.Label();
            this.lbl_V3 = new System.Windows.Forms.Label();
            this.lbl_R1 = new System.Windows.Forms.Label();
            this.lbl_R2 = new System.Windows.Forms.Label();
            this.lbl_R3 = new System.Windows.Forms.Label();
            this.btn_VTEST = new System.Windows.Forms.Button();
            this.btn_RTEST = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "傳值呼叫 Call By Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "傳址呼叫 Call By Reference";
            // 
            // lbl_V1
            // 
            this.lbl_V1.AutoSize = true;
            this.lbl_V1.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_V1.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_V1.Location = new System.Drawing.Point(31, 73);
            this.lbl_V1.Name = "lbl_V1";
            this.lbl_V1.Size = new System.Drawing.Size(71, 24);
            this.lbl_V1.TabIndex = 0;
            this.lbl_V1.Text = "CBV1";
            // 
            // lbl_V2
            // 
            this.lbl_V2.AutoSize = true;
            this.lbl_V2.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_V2.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_V2.Location = new System.Drawing.Point(31, 119);
            this.lbl_V2.Name = "lbl_V2";
            this.lbl_V2.Size = new System.Drawing.Size(71, 24);
            this.lbl_V2.TabIndex = 0;
            this.lbl_V2.Text = "CBV2";
            // 
            // lbl_V3
            // 
            this.lbl_V3.AutoSize = true;
            this.lbl_V3.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_V3.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_V3.Location = new System.Drawing.Point(31, 166);
            this.lbl_V3.Name = "lbl_V3";
            this.lbl_V3.Size = new System.Drawing.Size(71, 24);
            this.lbl_V3.TabIndex = 0;
            this.lbl_V3.Text = "CBV3";
            // 
            // lbl_R1
            // 
            this.lbl_R1.AutoSize = true;
            this.lbl_R1.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_R1.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_R1.Location = new System.Drawing.Point(31, 262);
            this.lbl_R1.Name = "lbl_R1";
            this.lbl_R1.Size = new System.Drawing.Size(70, 24);
            this.lbl_R1.TabIndex = 0;
            this.lbl_R1.Text = "CBR1";
            // 
            // lbl_R2
            // 
            this.lbl_R2.AutoSize = true;
            this.lbl_R2.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_R2.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_R2.Location = new System.Drawing.Point(31, 308);
            this.lbl_R2.Name = "lbl_R2";
            this.lbl_R2.Size = new System.Drawing.Size(70, 24);
            this.lbl_R2.TabIndex = 0;
            this.lbl_R2.Text = "CBR2";
            // 
            // lbl_R3
            // 
            this.lbl_R3.AutoSize = true;
            this.lbl_R3.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_R3.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_R3.Location = new System.Drawing.Point(31, 355);
            this.lbl_R3.Name = "lbl_R3";
            this.lbl_R3.Size = new System.Drawing.Size(70, 24);
            this.lbl_R3.TabIndex = 0;
            this.lbl_R3.Text = "CBR3";
            // 
            // btn_VTEST
            // 
            this.btn_VTEST.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_VTEST.Location = new System.Drawing.Point(303, 151);
            this.btn_VTEST.Name = "btn_VTEST";
            this.btn_VTEST.Size = new System.Drawing.Size(139, 39);
            this.btn_VTEST.TabIndex = 1;
            this.btn_VTEST.Text = "CBV測試";
            this.btn_VTEST.UseVisualStyleBackColor = true;
            this.btn_VTEST.Click += new System.EventHandler(this.btn_VTEST_Click);
            // 
            // btn_RTEST
            // 
            this.btn_RTEST.Font = new System.Drawing.Font("新細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_RTEST.Location = new System.Drawing.Point(303, 340);
            this.btn_RTEST.Name = "btn_RTEST";
            this.btn_RTEST.Size = new System.Drawing.Size(139, 39);
            this.btn_RTEST.TabIndex = 1;
            this.btn_RTEST.Text = "CRR測試";
            this.btn_RTEST.UseVisualStyleBackColor = true;
            this.btn_RTEST.Click += new System.EventHandler(this.btn_RTEST_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(484, 493);
            this.Controls.Add(this.btn_RTEST);
            this.Controls.Add(this.btn_VTEST);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_R3);
            this.Controls.Add(this.lbl_V3);
            this.Controls.Add(this.lbl_R2);
            this.Controls.Add(this.lbl_V2);
            this.Controls.Add(this.lbl_R1);
            this.Controls.Add(this.lbl_V1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "傳值呼叫與傳址呼叫";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_V1;
        private System.Windows.Forms.Label lbl_V2;
        private System.Windows.Forms.Label lbl_V3;
        private System.Windows.Forms.Label lbl_R1;
        private System.Windows.Forms.Label lbl_R2;
        private System.Windows.Forms.Label lbl_R3;
        private System.Windows.Forms.Button btn_VTEST;
        private System.Windows.Forms.Button btn_RTEST;
    }
}

