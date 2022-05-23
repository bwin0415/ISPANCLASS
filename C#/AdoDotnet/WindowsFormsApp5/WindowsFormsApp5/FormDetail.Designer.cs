
namespace WindowsFormsApp5
{
    partial class FormDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.產品價格 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtPicDetail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxChange = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPickPic = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.btnPickPic2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxChange.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "序號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "產品名稱";
            // 
            // 產品價格
            // 
            this.產品價格.AutoSize = true;
            this.產品價格.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.產品價格.Location = new System.Drawing.Point(32, 178);
            this.產品價格.Name = "產品價格";
            this.產品價格.Size = new System.Drawing.Size(93, 19);
            this.產品價格.TabIndex = 0;
            this.產品價格.Text = "產品價格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(32, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "產品描述";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(307, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(106, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "00000000";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(460, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "產品圖檔";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(247, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 27);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(247, 177);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(166, 27);
            this.txtprice.TabIndex = 1;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPicDetail
            // 
            this.txtPicDetail.Location = new System.Drawing.Point(142, 242);
            this.txtPicDetail.Multiline = true;
            this.txtPicDetail.Name = "txtPicDetail";
            this.txtPicDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPicDetail.Size = new System.Drawing.Size(271, 211);
            this.txtPicDetail.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(464, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxChange
            // 
            this.groupBoxChange.Controls.Add(this.btnSave);
            this.groupBoxChange.Controls.Add(this.btnPickPic);
            this.groupBoxChange.Location = new System.Drawing.Point(42, 486);
            this.groupBoxChange.Name = "groupBoxChange";
            this.groupBoxChange.Size = new System.Drawing.Size(371, 169);
            this.groupBoxChange.TabIndex = 3;
            this.groupBoxChange.TabStop = false;
            this.groupBoxChange.Text = "修改商品資訊";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "儲存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPickPic
            // 
            this.btnPickPic.Location = new System.Drawing.Point(100, 47);
            this.btnPickPic.Name = "btnPickPic";
            this.btnPickPic.Size = new System.Drawing.Size(164, 45);
            this.btnPickPic.TabIndex = 0;
            this.btnPickPic.Text = "選取商品照片";
            this.btnPickPic.UseVisualStyleBackColor = true;
            this.btnPickPic.Click += new System.EventHandler(this.btnPickPic_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.btnSave2);
            this.groupBoxAdd.Controls.Add(this.buttonADD);
            this.groupBoxAdd.Controls.Add(this.btnPickPic2);
            this.groupBoxAdd.Location = new System.Drawing.Point(464, 486);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(371, 169);
            this.groupBoxAdd.TabIndex = 3;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "新增商品資訊";
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(112, 124);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(164, 28);
            this.btnSave2.TabIndex = 0;
            this.btnSave2.Text = "儲存修改";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(112, 26);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(164, 26);
            this.buttonADD.TabIndex = 0;
            this.buttonADD.Text = "新增商品";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // btnPickPic2
            // 
            this.btnPickPic2.Location = new System.Drawing.Point(112, 71);
            this.btnPickPic2.Name = "btnPickPic2";
            this.btnPickPic2.Size = new System.Drawing.Size(164, 28);
            this.btnPickPic2.TabIndex = 0;
            this.btnPickPic2.Text = "選取商品照片";
            this.btnPickPic2.UseVisualStyleBackColor = true;
            this.btnPickPic2.Click += new System.EventHandler(this.btnPickPic_Click);
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(886, 723);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxChange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPicDetail);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.產品價格);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDetail";
            this.Text = "商品詳細資訊";
            this.Load += new System.EventHandler(this.FormDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxChange.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 產品價格;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtPicDetail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPickPic;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button btnPickPic2;
    }
}