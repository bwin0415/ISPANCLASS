
namespace WindowsFormsApp5
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
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.lblsumtitle = new System.Windows.Forms.Label();
            this.lbl_sumoutput = new System.Windows.Forms.Label();
            this.lblavergrtitle = new System.Windows.Forms.Label();
            this.lbl_AvergeOutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NameSort = new System.Windows.Forms.Button();
            this.btn_GradeSort = new System.Windows.Forms.Button();
            this.btn_AllStudentSort = new System.Windows.Forms.Button();
            this.Txt_NameInput = new System.Windows.Forms.TextBox();
            this.btn_FindAStudent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.MintCream;
            this.lbl.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl.Location = new System.Drawing.Point(324, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(160, 24);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "學生成績系統";
            // 
            // lbl_output
            // 
            this.lbl_output.BackColor = System.Drawing.Color.MintCream;
            this.lbl_output.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_output.Location = new System.Drawing.Point(22, 53);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(462, 347);
            this.lbl_output.TabIndex = 0;
            this.lbl_output.Text = "資料結果顯示";
            // 
            // lblsumtitle
            // 
            this.lblsumtitle.AutoSize = true;
            this.lblsumtitle.BackColor = System.Drawing.Color.MintCream;
            this.lblsumtitle.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblsumtitle.Location = new System.Drawing.Point(528, 216);
            this.lblsumtitle.Name = "lblsumtitle";
            this.lblsumtitle.Size = new System.Drawing.Size(110, 24);
            this.lblsumtitle.TabIndex = 0;
            this.lblsumtitle.Text = "成績總和";
            // 
            // lbl_sumoutput
            // 
            this.lbl_sumoutput.AutoSize = true;
            this.lbl_sumoutput.BackColor = System.Drawing.Color.MintCream;
            this.lbl_sumoutput.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_sumoutput.Location = new System.Drawing.Point(576, 267);
            this.lbl_sumoutput.Name = "lbl_sumoutput";
            this.lbl_sumoutput.Size = new System.Drawing.Size(110, 24);
            this.lbl_sumoutput.TabIndex = 0;
            this.lbl_sumoutput.Text = "計算結果";
            // 
            // lblavergrtitle
            // 
            this.lblavergrtitle.AutoSize = true;
            this.lblavergrtitle.BackColor = System.Drawing.Color.MintCream;
            this.lblavergrtitle.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblavergrtitle.Location = new System.Drawing.Point(528, 319);
            this.lblavergrtitle.Name = "lblavergrtitle";
            this.lblavergrtitle.Size = new System.Drawing.Size(110, 24);
            this.lblavergrtitle.TabIndex = 0;
            this.lblavergrtitle.Text = "成績平均";
            // 
            // lbl_AvergeOutput
            // 
            this.lbl_AvergeOutput.AutoSize = true;
            this.lbl_AvergeOutput.BackColor = System.Drawing.Color.MintCream;
            this.lbl_AvergeOutput.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_AvergeOutput.Location = new System.Drawing.Point(576, 376);
            this.lbl_AvergeOutput.Name = "lbl_AvergeOutput";
            this.lbl_AvergeOutput.Size = new System.Drawing.Size(110, 24);
            this.lbl_AvergeOutput.TabIndex = 0;
            this.lbl_AvergeOutput.Text = "計算結果";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.btn_FindAStudent);
            this.groupBox1.Controls.Add(this.Txt_NameInput);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(404, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋功能";
            // 
            // btn_NameSort
            // 
            this.btn_NameSort.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_NameSort.Location = new System.Drawing.Point(36, 433);
            this.btn_NameSort.Name = "btn_NameSort";
            this.btn_NameSort.Size = new System.Drawing.Size(140, 38);
            this.btn_NameSort.TabIndex = 2;
            this.btn_NameSort.Text = "姓名排序";
            this.btn_NameSort.UseVisualStyleBackColor = true;
            this.btn_NameSort.Click += new System.EventHandler(this.btn_NameSort_Click);
            // 
            // btn_GradeSort
            // 
            this.btn_GradeSort.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GradeSort.Location = new System.Drawing.Point(193, 433);
            this.btn_GradeSort.Name = "btn_GradeSort";
            this.btn_GradeSort.Size = new System.Drawing.Size(137, 38);
            this.btn_GradeSort.TabIndex = 2;
            this.btn_GradeSort.Text = "成績排序";
            this.btn_GradeSort.UseVisualStyleBackColor = true;
            this.btn_GradeSort.Click += new System.EventHandler(this.btn_GradeSort_Click);
            // 
            // btn_AllStudentSort
            // 
            this.btn_AllStudentSort.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AllStudentSort.Location = new System.Drawing.Point(36, 486);
            this.btn_AllStudentSort.Name = "btn_AllStudentSort";
            this.btn_AllStudentSort.Size = new System.Drawing.Size(294, 38);
            this.btn_AllStudentSort.TabIndex = 2;
            this.btn_AllStudentSort.Text = "列出所有學生";
            this.btn_AllStudentSort.UseVisualStyleBackColor = true;
            this.btn_AllStudentSort.Click += new System.EventHandler(this.btn_AllStudentSort_Click);
            // 
            // Txt_NameInput
            // 
            this.Txt_NameInput.Location = new System.Drawing.Point(69, 35);
            this.Txt_NameInput.Name = "Txt_NameInput";
            this.Txt_NameInput.Size = new System.Drawing.Size(189, 36);
            this.Txt_NameInput.TabIndex = 0;
            // 
            // btn_FindAStudent
            // 
            this.btn_FindAStudent.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FindAStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_FindAStudent.Location = new System.Drawing.Point(78, 77);
            this.btn_FindAStudent.Name = "btn_FindAStudent";
            this.btn_FindAStudent.Size = new System.Drawing.Size(156, 38);
            this.btn_FindAStudent.TabIndex = 2;
            this.btn_FindAStudent.Text = "姓名搜尋";
            this.btn_FindAStudent.UseVisualStyleBackColor = true;
            this.btn_FindAStudent.Click += new System.EventHandler(this.btn_FindAStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(778, 581);
            this.Controls.Add(this.btn_AllStudentSort);
            this.Controls.Add(this.btn_GradeSort);
            this.Controls.Add(this.btn_NameSort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblavergrtitle);
            this.Controls.Add(this.lbl_AvergeOutput);
            this.Controls.Add(this.lbl_sumoutput);
            this.Controls.Add(this.lblsumtitle);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Array的進階應用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lblsumtitle;
        private System.Windows.Forms.Label lbl_sumoutput;
        private System.Windows.Forms.Label lblavergrtitle;
        private System.Windows.Forms.Label lbl_AvergeOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_FindAStudent;
        private System.Windows.Forms.TextBox Txt_NameInput;
        private System.Windows.Forms.Button btn_NameSort;
        private System.Windows.Forms.Button btn_GradeSort;
        private System.Windows.Forms.Button btn_AllStudentSort;
    }
}

