
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
            this.btn_無參數 = new System.Windows.Forms.Button();
            this.btn_有參數 = new System.Windows.Forms.Button();
            this.btn_回傳值 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_無參數
            // 
            this.btn_無參數.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_無參數.Location = new System.Drawing.Point(28, 79);
            this.btn_無參數.Name = "btn_無參數";
            this.btn_無參數.Size = new System.Drawing.Size(250, 75);
            this.btn_無參數.TabIndex = 0;
            this.btn_無參數.Text = "無參數方法";
            this.btn_無參數.UseVisualStyleBackColor = true;
            this.btn_無參數.Click += new System.EventHandler(this.btn_無參數_Click);
            // 
            // btn_有參數
            // 
            this.btn_有參數.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_有參數.Location = new System.Drawing.Point(28, 202);
            this.btn_有參數.Name = "btn_有參數";
            this.btn_有參數.Size = new System.Drawing.Size(250, 75);
            this.btn_有參數.TabIndex = 0;
            this.btn_有參數.Text = "有參數方法";
            this.btn_有參數.UseVisualStyleBackColor = true;
            this.btn_有參數.Click += new System.EventHandler(this.btn_有參數_Click);
            // 
            // btn_回傳值
            // 
            this.btn_回傳值.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_回傳值.Location = new System.Drawing.Point(28, 327);
            this.btn_回傳值.Name = "btn_回傳值";
            this.btn_回傳值.Size = new System.Drawing.Size(250, 75);
            this.btn_回傳值.TabIndex = 0;
            this.btn_回傳值.Text = "回傳值方法";
            this.btn_回傳值.UseVisualStyleBackColor = true;
            this.btn_回傳值.Click += new System.EventHandler(this.btn_回傳值_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btn_回傳值);
            this.Controls.Add(this.btn_有參數);
            this.Controls.Add(this.btn_無參數);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_無參數;
        private System.Windows.Forms.Button btn_有參數;
        private System.Windows.Forms.Button btn_回傳值;
    }
}

