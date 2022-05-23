
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myDbDataSet = new WindowsFormsApp3.myDbDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new WindowsFormsApp3.myDbDataSetTableAdapters.PersonsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.myDbDataSetTableAdapters.TableAdapterManager();
            this.personsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.chkMarriage = new System.Windows.Forms.CheckBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnFirstData = new System.Windows.Forms.Button();
            this.btnLastData = new System.Windows.Forms.Button();
            this.btnNextData = new System.Windows.Forms.Button();
            this.btnFinData = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnNewData = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.cBoxEmail = new System.Windows.Forms.ComboBox();
            this.lBoxName = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cBoxFind = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cBoxFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).BeginInit();
            this.personsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // myDbDataSet
            // 
            this.myDbDataSet.DataSetName = "myDbDataSet";
            this.myDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.myDbDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.myDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personsBindingNavigator
            // 
            this.personsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personsBindingNavigator.BindingSource = this.personsBindingSource;
            this.personsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personsBindingNavigatorSaveItem});
            this.personsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personsBindingNavigator.Name = "personsBindingNavigator";
            this.personsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personsBindingNavigator.Size = new System.Drawing.Size(914, 25);
            this.personsBindingNavigator.TabIndex = 0;
            this.personsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personsBindingNavigatorSaveItem
            // 
            this.personsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personsBindingNavigatorSaveItem.Image")));
            this.personsBindingNavigatorSaveItem.Name = "personsBindingNavigatorSaveItem";
            this.personsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personsBindingNavigatorSaveItem.Text = "儲存資料";
            this.personsBindingNavigatorSaveItem.Click += new System.EventHandler(this.personsBindingNavigatorSaveItem_Click);
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AutoGenerateColumns = false;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.personsDataGridView.DataSource = this.personsBindingSource;
            this.personsDataGridView.Location = new System.Drawing.Point(857, 36);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.RowTemplate.Height = 24;
            this.personsDataGridView.Size = new System.Drawing.Size(57, 43);
            this.personsDataGridView.TabIndex = 1;
            this.personsDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "姓名";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "電話";
            this.dataGridViewTextBoxColumn3.HeaderText = "電話";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "地址";
            this.dataGridViewTextBoxColumn4.HeaderText = "地址";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "生日";
            this.dataGridViewTextBoxColumn6.HeaderText = "生日";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "婚姻狀態";
            this.dataGridViewCheckBoxColumn1.HeaderText = "婚姻狀態";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "會員點數";
            this.dataGridViewTextBoxColumn7.HeaderText = "會員點數";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl.Location = new System.Drawing.Point(32, 36);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(34, 21);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "電話";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(32, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(32, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "生日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(32, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "婚姻狀態";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(32, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "點數";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Id", true));
            this.lblID.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(122, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(83, 21);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "0";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "姓名", true));
            this.txtName.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(126, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 23);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "電話", true));
            this.txtPhone.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(126, 106);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(178, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "地址", true));
            this.txtAdress.Location = new System.Drawing.Point(126, 140);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(342, 22);
            this.txtAdress.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(126, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPoint
            // 
            this.txtPoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "會員點數", true));
            this.txtPoint.Location = new System.Drawing.Point(126, 285);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(178, 22);
            this.txtPoint.TabIndex = 3;
            // 
            // chkMarriage
            // 
            this.chkMarriage.AutoSize = true;
            this.chkMarriage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.personsBindingSource, "婚姻狀態", true));
            this.chkMarriage.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkMarriage.Location = new System.Drawing.Point(234, 245);
            this.chkMarriage.Name = "chkMarriage";
            this.chkMarriage.Size = new System.Drawing.Size(70, 23);
            this.chkMarriage.TabIndex = 4;
            this.chkMarriage.Text = "已婚";
            this.chkMarriage.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsBindingSource, "生日", true));
            this.dtpBirthday.Location = new System.Drawing.Point(126, 212);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(178, 22);
            this.dtpBirthday.TabIndex = 5;
            // 
            // btnFirstData
            // 
            this.btnFirstData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFirstData.Location = new System.Drawing.Point(34, 371);
            this.btnFirstData.Name = "btnFirstData";
            this.btnFirstData.Size = new System.Drawing.Size(116, 38);
            this.btnFirstData.TabIndex = 6;
            this.btnFirstData.Text = "第一筆";
            this.btnFirstData.UseVisualStyleBackColor = true;
            this.btnFirstData.Click += new System.EventHandler(this.btnFirstData_Click);
            // 
            // btnLastData
            // 
            this.btnLastData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLastData.Location = new System.Drawing.Point(156, 371);
            this.btnLastData.Name = "btnLastData";
            this.btnLastData.Size = new System.Drawing.Size(116, 38);
            this.btnLastData.TabIndex = 6;
            this.btnLastData.Text = "上一筆";
            this.btnLastData.UseVisualStyleBackColor = true;
            this.btnLastData.Click += new System.EventHandler(this.btnLastData_Click);
            // 
            // btnNextData
            // 
            this.btnNextData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextData.Location = new System.Drawing.Point(278, 371);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(116, 38);
            this.btnNextData.TabIndex = 6;
            this.btnNextData.Text = "下一筆";
            this.btnNextData.UseVisualStyleBackColor = true;
            this.btnNextData.Click += new System.EventHandler(this.btnNextData_Click);
            // 
            // btnFinData
            // 
            this.btnFinData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFinData.Location = new System.Drawing.Point(415, 371);
            this.btnFinData.Name = "btnFinData";
            this.btnFinData.Size = new System.Drawing.Size(116, 38);
            this.btnFinData.TabIndex = 6;
            this.btnFinData.Text = "最後一筆";
            this.btnFinData.UseVisualStyleBackColor = true;
            this.btnFinData.Click += new System.EventHandler(this.btnFinData_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(36, 430);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(116, 38);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "儲存修改";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(158, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUndo.Location = new System.Drawing.Point(280, 430);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(116, 38);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "復原";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.btnSaveData);
            this.groupBox1.Controls.Add(this.btnNewData);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(537, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增資料";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveData.Location = new System.Drawing.Point(187, 38);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(116, 38);
            this.btnSaveData.TabIndex = 6;
            this.btnSaveData.Text = "儲存";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnNewData
            // 
            this.btnNewData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewData.Location = new System.Drawing.Point(28, 38);
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(116, 38);
            this.btnNewData.TabIndex = 6;
            this.btnNewData.Text = "新增";
            this.btnNewData.UseVisualStyleBackColor = true;
            this.btnNewData.Click += new System.EventHandler(this.btnNewData_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPage.Location = new System.Drawing.Point(744, 355);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(138, 21);
            this.lblPage.TabIndex = 2;
            this.lblPage.Text = "第X筆/共X筆";
            // 
            // cBoxEmail
            // 
            this.cBoxEmail.DataSource = this.personsBindingSource;
            this.cBoxEmail.DisplayMember = "Email";
            this.cBoxEmail.FormattingEnabled = true;
            this.cBoxEmail.Location = new System.Drawing.Point(513, 175);
            this.cBoxEmail.Name = "cBoxEmail";
            this.cBoxEmail.Size = new System.Drawing.Size(212, 20);
            this.cBoxEmail.TabIndex = 8;
            // 
            // lBoxName
            // 
            this.lBoxName.DataSource = this.personsBindingSource;
            this.lBoxName.DisplayMember = "姓名";
            this.lBoxName.FormattingEnabled = true;
            this.lBoxName.ItemHeight = 12;
            this.lBoxName.Location = new System.Drawing.Point(513, 38);
            this.lBoxName.Name = "lBoxName";
            this.lBoxName.Size = new System.Drawing.Size(212, 124);
            this.lBoxName.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.btnRemoveFilter);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.cBoxFilter);
            this.groupBox2.Controls.Add(this.cBoxFind);
            this.groupBox2.Controls.Add(this.txtFilter);
            this.groupBox2.Controls.Add(this.txtFind);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(314, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 118);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜尋功能";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFind.Location = new System.Drawing.Point(7, 33);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(175, 27);
            this.txtFind.TabIndex = 0;
            // 
            // cBoxFind
            // 
            this.cBoxFind.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxFind.FormattingEnabled = true;
            this.cBoxFind.Location = new System.Drawing.Point(197, 33);
            this.cBoxFind.Name = "cBoxFind";
            this.cBoxFind.Size = new System.Drawing.Size(121, 24);
            this.cBoxFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFind.Location = new System.Drawing.Point(336, 33);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFilter.Location = new System.Drawing.Point(6, 73);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(175, 27);
            this.txtFilter.TabIndex = 0;
            // 
            // cBoxFilter
            // 
            this.cBoxFilter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxFilter.FormattingEnabled = true;
            this.cBoxFilter.Location = new System.Drawing.Point(197, 76);
            this.cBoxFilter.Name = "cBoxFilter";
            this.cBoxFilter.Size = new System.Drawing.Size(121, 24);
            this.cBoxFilter.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFilter.Location = new System.Drawing.Point(336, 76);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveFilter.Location = new System.Drawing.Point(451, 33);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(111, 67);
            this.btnRemoveFilter.TabIndex = 2;
            this.btnRemoveFilter.Text = "條件移除";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(914, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lBoxName);
            this.Controls.Add(this.cBoxEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFinData);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnLastData);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnFirstData);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.chkMarriage);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.personsDataGridView);
            this.Controls.Add(this.personsBindingNavigator);
            this.Name = "Form1";
            this.Text = "會員資料表單SQLSERVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).EndInit();
            this.personsBindingNavigator.ResumeLayout(false);
            this.personsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDbDataSet myDbDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private myDbDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private myDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.CheckBox chkMarriage;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnFirstData;
        private System.Windows.Forms.Button btnLastData;
        private System.Windows.Forms.Button btnNextData;
        private System.Windows.Forms.Button btnFinData;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnNewData;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.ComboBox cBoxEmail;
        private System.Windows.Forms.ListBox lBoxName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cBoxFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cBoxFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnRemoveFilter;
    }
}

