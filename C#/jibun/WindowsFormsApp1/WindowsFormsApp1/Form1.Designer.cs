
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
            this.lblmain = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btntea = new System.Windows.Forms.Button();
            this.btngreentea = new System.Windows.Forms.Button();
            this.btnmilk = new System.Windows.Forms.Button();
            this.btn_happywater = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Font = new System.Drawing.Font("新宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.Color.LightCyan;
            this.lblmain.Location = new System.Drawing.Point(183, 36);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(312, 33);
            this.lblmain.TabIndex = 0;
            this.lblmain.Text = "冰涼冷飲自動販賣機\r\n";
            // 
            // lblmessage
            // 
            this.lblmessage.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblmessage.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblmessage.Location = new System.Drawing.Point(35, 115);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lblmessage.Size = new System.Drawing.Size(436, 452);
            this.lblmessage.TabIndex = 0;
            this.lblmessage.Text = "回應訊息";
            // 
            // btntea
            // 
            this.btntea.BackColor = System.Drawing.Color.Salmon;
            this.btntea.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btntea.Location = new System.Drawing.Point(547, 115);
            this.btntea.Name = "btntea";
            this.btntea.Size = new System.Drawing.Size(128, 71);
            this.btntea.TabIndex = 1;
            this.btntea.Text = "紅 茶";
            this.btntea.UseVisualStyleBackColor = false;
            this.btntea.Click += new System.EventHandler(this.btntea_Click);
            // 
            // btngreentea
            // 
            this.btngreentea.BackColor = System.Drawing.Color.PaleGreen;
            this.btngreentea.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btngreentea.Location = new System.Drawing.Point(547, 236);
            this.btngreentea.Name = "btngreentea";
            this.btngreentea.Size = new System.Drawing.Size(128, 71);
            this.btngreentea.TabIndex = 1;
            this.btngreentea.Text = "綠 茶";
            this.btngreentea.UseVisualStyleBackColor = false;
            this.btngreentea.Click += new System.EventHandler(this.btngreentea_Click);
            // 
            // btnmilk
            // 
            this.btnmilk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnmilk.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmilk.Location = new System.Drawing.Point(547, 369);
            this.btnmilk.Name = "btnmilk";
            this.btnmilk.Size = new System.Drawing.Size(128, 71);
            this.btnmilk.TabIndex = 1;
            this.btnmilk.Text = "奶 茶";
            this.btnmilk.UseVisualStyleBackColor = false;
            this.btnmilk.Click += new System.EventHandler(this.btnmilk_Click);
            // 
            // btn_happywater
            // 
            this.btn_happywater.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_happywater.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_happywater.ForeColor = System.Drawing.Color.MintCream;
            this.btn_happywater.Location = new System.Drawing.Point(547, 496);
            this.btn_happywater.Name = "btn_happywater";
            this.btn_happywater.Size = new System.Drawing.Size(128, 71);
            this.btn_happywater.TabIndex = 1;
            this.btn_happywater.Text = "快 樂 水";
            this.btn_happywater.UseVisualStyleBackColor = false;
            this.btn_happywater.Click += new System.EventHandler(this.btn_happywater_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(728, 647);
            this.Controls.Add(this.btn_happywater);
            this.Controls.Add(this.btnmilk);
            this.Controls.Add(this.btngreentea);
            this.Controls.Add(this.btntea);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lblmain);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "冷飲自動販賣機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmain;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btntea;
        private System.Windows.Forms.Button btngreentea;
        private System.Windows.Forms.Button btnmilk;
        private System.Windows.Forms.Button btn_happywater;
    }
}

