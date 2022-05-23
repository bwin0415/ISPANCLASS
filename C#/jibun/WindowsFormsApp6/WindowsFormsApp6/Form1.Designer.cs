
namespace WindowsFormsApp6
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
            this.btn_L = new System.Windows.Forms.Button();
            this.btn_AL = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_Ht = new System.Windows.Forms.Button();
            this.btn_string = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_L
            // 
            this.btn_L.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_L.Location = new System.Drawing.Point(86, 46);
            this.btn_L.Name = "btn_L";
            this.btn_L.Size = new System.Drawing.Size(160, 51);
            this.btn_L.TabIndex = 0;
            this.btn_L.Text = "List";
            this.btn_L.UseVisualStyleBackColor = true;
            this.btn_L.Click += new System.EventHandler(this.btn_L_Click);
            // 
            // btn_AL
            // 
            this.btn_AL.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AL.Location = new System.Drawing.Point(86, 192);
            this.btn_AL.Name = "btn_AL";
            this.btn_AL.Size = new System.Drawing.Size(160, 51);
            this.btn_AL.TabIndex = 0;
            this.btn_AL.Text = "ArrayList";
            this.btn_AL.UseVisualStyleBackColor = true;
            this.btn_AL.Click += new System.EventHandler(this.btn_AL_Click);
            // 
            // btn_D
            // 
            this.btn_D.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_D.Location = new System.Drawing.Point(86, 346);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(160, 51);
            this.btn_D.TabIndex = 0;
            this.btn_D.Text = "Dictionary";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_Ht
            // 
            this.btn_Ht.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Ht.Location = new System.Drawing.Point(86, 509);
            this.btn_Ht.Name = "btn_Ht";
            this.btn_Ht.Size = new System.Drawing.Size(160, 51);
            this.btn_Ht.TabIndex = 0;
            this.btn_Ht.Text = "Hashtable";
            this.btn_Ht.UseVisualStyleBackColor = true;
            this.btn_Ht.Click += new System.EventHandler(this.btn_Ht_Click);
            // 
            // btn_string
            // 
            this.btn_string.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_string.Location = new System.Drawing.Point(86, 683);
            this.btn_string.Name = "btn_string";
            this.btn_string.Size = new System.Drawing.Size(160, 51);
            this.btn_string.TabIndex = 0;
            this.btn_string.Text = "String進階";
            this.btn_string.UseVisualStyleBackColor = true;
            this.btn_string.Click += new System.EventHandler(this.btn_string_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(384, 815);
            this.Controls.Add(this.btn_string);
            this.Controls.Add(this.btn_Ht);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_AL);
            this.Controls.Add(this.btn_L);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "Colections";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_L;
        private System.Windows.Forms.Button btn_AL;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_Ht;
        private System.Windows.Forms.Button btn_string;
    }
}

