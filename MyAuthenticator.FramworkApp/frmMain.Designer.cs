namespace MyAuthenticator.FramworkApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.دریافترمزعبوردرزمانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIsGetPasswordForShowSecretKey = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIsGetPasswordForShowDynamicPasswordKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQrCodeSecretKey = new System.Windows.Forms.Button();
            this.btnCopySecretKey = new System.Windows.Forms.Button();
            this.btnShowSecretKey = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdPassword = new System.Windows.Forms.DataGridView();
            this.mnuPassword = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerClearPassword = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.btnIsGetPasswordForRestoreBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPassword = new System.Windows.Forms.BindingSource(this.components);
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Between = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPassword)).BeginInit();
            this.mnuPassword.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.grdPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(589, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.دریافترمزعبوردرزمانToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(193, 22);
            this.btnChangePassword.Text = "تغییر رمز عبور";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // دریافترمزعبوردرزمانToolStripMenuItem
            // 
            this.دریافترمزعبوردرزمانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIsGetPasswordForShowSecretKey,
            this.btnIsGetPasswordForShowDynamicPasswordKey,
            this.btnIsGetPasswordForRestoreBackup});
            this.دریافترمزعبوردرزمانToolStripMenuItem.Name = "دریافترمزعبوردرزمانToolStripMenuItem";
            this.دریافترمزعبوردرزمانToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.دریافترمزعبوردرزمانToolStripMenuItem.Text = "دریافت رمز عبور در زمان";
            // 
            // btnIsGetPasswordForShowSecretKey
            // 
            this.btnIsGetPasswordForShowSecretKey.Name = "btnIsGetPasswordForShowSecretKey";
            this.btnIsGetPasswordForShowSecretKey.Size = new System.Drawing.Size(227, 22);
            this.btnIsGetPasswordForShowSecretKey.Text = "نمایش کد امنیتی";
            this.btnIsGetPasswordForShowSecretKey.Click += new System.EventHandler(this.btnIsGetPasswordForShowSecretKey_Click);
            // 
            // btnIsGetPasswordForShowDynamicPasswordKey
            // 
            this.btnIsGetPasswordForShowDynamicPasswordKey.Name = "btnIsGetPasswordForShowDynamicPasswordKey";
            this.btnIsGetPasswordForShowDynamicPasswordKey.Size = new System.Drawing.Size(227, 22);
            this.btnIsGetPasswordForShowDynamicPasswordKey.Text = "نمایش کلمه عبور پویا";
            this.btnIsGetPasswordForShowDynamicPasswordKey.Click += new System.EventHandler(this.btnIsGetPasswordForShowDynamicPasswordKey_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBackup,
            this.btnRestore,
            this.btnDeleteDatabase});
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(70, 22);
            this.toolStripDropDownButton2.Text = "پایگاه داده";
            // 
            // btnBackup
            // 
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(180, 22);
            this.btnBackup.Text = "دریافت نسخه پشتیبان";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(180, 22);
            this.btnRestore.Text = "بازیابی نسخه پشتیبان";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDeleteDatabase
            // 
            this.btnDeleteDatabase.Name = "btnDeleteDatabase";
            this.btnDeleteDatabase.Size = new System.Drawing.Size(180, 22);
            this.btnDeleteDatabase.Text = "پاک کردن پایگاه داده";
            this.btnDeleteDatabase.Click += new System.EventHandler(this.btnDeleteDatabase_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnQrCodeSecretKey);
            this.panel1.Controls.Add(this.btnCopySecretKey);
            this.panel1.Controls.Add(this.btnShowSecretKey);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSecretKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(581, 86);
            this.panel1.TabIndex = 13;
            // 
            // btnQrCodeSecretKey
            // 
            this.btnQrCodeSecretKey.BackgroundImage = global::MyAuthenticator.FramworkApp.Properties.Resources.QrCode;
            this.btnQrCodeSecretKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQrCodeSecretKey.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password;
            this.btnQrCodeSecretKey.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQrCodeSecretKey.Location = new System.Drawing.Point(8, 49);
            this.btnQrCodeSecretKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnQrCodeSecretKey.Name = "btnQrCodeSecretKey";
            this.btnQrCodeSecretKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnQrCodeSecretKey.Size = new System.Drawing.Size(42, 25);
            this.btnQrCodeSecretKey.TabIndex = 12;
            this.btnQrCodeSecretKey.Tag = "نمایش بارکد کد امنیتی";
            this.btnQrCodeSecretKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQrCodeSecretKey.UseVisualStyleBackColor = true;
            this.btnQrCodeSecretKey.Click += new System.EventHandler(this.btnQrCodeSecretKey_Click);
            // 
            // btnCopySecretKey
            // 
            this.btnCopySecretKey.BackgroundImage = global::MyAuthenticator.FramworkApp.Properties.Resources.Copy;
            this.btnCopySecretKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCopySecretKey.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password;
            this.btnCopySecretKey.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopySecretKey.Location = new System.Drawing.Point(56, 49);
            this.btnCopySecretKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCopySecretKey.Name = "btnCopySecretKey";
            this.btnCopySecretKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCopySecretKey.Size = new System.Drawing.Size(42, 25);
            this.btnCopySecretKey.TabIndex = 11;
            this.btnCopySecretKey.Tag = "کپی کد امنیتی";
            this.btnCopySecretKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopySecretKey.UseVisualStyleBackColor = true;
            this.btnCopySecretKey.Click += new System.EventHandler(this.btnCopySecretKey_Click);
            // 
            // btnShowSecretKey
            // 
            this.btnShowSecretKey.BackgroundImage = global::MyAuthenticator.FramworkApp.Properties.Resources.Show;
            this.btnShowSecretKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowSecretKey.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password;
            this.btnShowSecretKey.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowSecretKey.Location = new System.Drawing.Point(108, 49);
            this.btnShowSecretKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnShowSecretKey.Name = "btnShowSecretKey";
            this.btnShowSecretKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowSecretKey.Size = new System.Drawing.Size(40, 25);
            this.btnShowSecretKey.TabIndex = 10;
            this.btnShowSecretKey.Tag = "نمایش کد امنیتی";
            this.btnShowSecretKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowSecretKey.UseVisualStyleBackColor = true;
            this.btnShowSecretKey.Click += new System.EventHandler(this.btnShowSecretKey_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(480, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(480, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "کد امنیتی :";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecretKey.Enabled = false;
            this.txtSecretKey.Location = new System.Drawing.Point(158, 47);
            this.txtSecretKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(313, 27);
            this.txtSecretKey.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام :";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(8, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(463, 27);
            this.txtName.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnAcc);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 323);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 40);
            this.panel3.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(42, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Tag = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Enabled = false;
            this.btnAcc.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Accept;
            this.btnAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcc.Location = new System.Drawing.Point(7, 7);
            this.btnAcc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(25, 25);
            this.btnAcc.TabIndex = 3;
            this.btnAcc.Tag = "تائید";
            this.btnAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Delete1;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(474, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Tag = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(509, 7);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 25);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Tag = "ویرایش";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(544, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Tag = "ایجاد";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdPassword
            // 
            this.grdPassword.AllowUserToAddRows = false;
            this.grdPassword.AllowUserToDeleteRows = false;
            this.grdPassword.AllowUserToOrderColumns = true;
            this.grdPassword.AutoGenerateColumns = false;
            this.grdPassword.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdPassword.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.Title,
            this.PasswordString,
            this.Counter,
            this.Up,
            this.Down,
            this.Between});
            this.grdPassword.DataSource = this.bsPassword;
            this.grdPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPassword.Location = new System.Drawing.Point(4, 171);
            this.grdPassword.Margin = new System.Windows.Forms.Padding(4);
            this.grdPassword.Name = "grdPassword";
            this.grdPassword.ReadOnly = true;
            this.grdPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdPassword.Size = new System.Drawing.Size(581, 142);
            this.grdPassword.TabIndex = 12;
            this.grdPassword.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPassword_CellContentDoubleClick);
            // 
            // mnuPassword
            // 
            this.mnuPassword.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowPassword,
            this.btnCopyPassword});
            this.mnuPassword.Name = "mnuPassword";
            this.mnuPassword.Size = new System.Drawing.Size(158, 48);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password;
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(157, 22);
            this.btnShowPassword.Text = "نمایش کلمه عبور";
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password;
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(157, 22);
            this.btnCopyPassword.Text = "کپی کلمه عبور";
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNameSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(581, 38);
            this.panel2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "جستجو نام :";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSearch.Location = new System.Drawing.Point(8, 4);
            this.txtNameSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(463, 27);
            this.txtNameSearch.TabIndex = 10;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.SearchData);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PasswordData";
            this.dataGridViewTextBoxColumn1.HeaderText = "PasswordData";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // timerClearPassword
            // 
            this.timerClearPassword.Tick += new System.EventHandler(this.timerClearPassword_Tick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PasswordData";
            this.dataGridViewTextBoxColumn2.HeaderText = "PasswordData";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Backup|*.bak";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Backup|*.bak";
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // btnIsGetPasswordForRestoreBackup
            // 
            this.btnIsGetPasswordForRestoreBackup.Name = "btnIsGetPasswordForRestoreBackup";
            this.btnIsGetPasswordForRestoreBackup.Size = new System.Drawing.Size(227, 22);
            this.btnIsGetPasswordForRestoreBackup.Text = "دریافت یا بازیابی نسخه پشتیبان";
            this.btnIsGetPasswordForRestoreBackup.Click += new System.EventHandler(this.btnIsGetPasswordForRestoreBackup_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PasswordData";
            this.dataGridViewTextBoxColumn3.HeaderText = "PasswordData";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bsPassword
            // 
            this.bsPassword.DataSource = typeof(MyAuthenticator.FramworkApp.PasswordDTO);
            this.bsPassword.CurrentChanged += new System.EventHandler(this.bsPassword_CurrentChanged);
            // 
            // RowNumber
            // 
            this.RowNumber.DataPropertyName = "RowNumber";
            this.RowNumber.HeaderText = "ردیف";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.Width = 50;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "نام";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // PasswordString
            // 
            this.PasswordString.ContextMenuStrip = this.mnuPassword;
            this.PasswordString.DataPropertyName = "PasswordString";
            this.PasswordString.HeaderText = "کلمه عبور پویا";
            this.PasswordString.Name = "PasswordString";
            this.PasswordString.ReadOnly = true;
            // 
            // Counter
            // 
            this.Counter.DataPropertyName = "Counter";
            this.Counter.HeaderText = "";
            this.Counter.Name = "Counter";
            this.Counter.ReadOnly = true;
            this.Counter.Width = 32;
            // 
            // Up
            // 
            this.Up.Description = "Up";
            this.Up.HeaderText = "";
            this.Up.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Up;
            this.Up.Name = "Up";
            this.Up.ReadOnly = true;
            this.Up.Width = 24;
            // 
            // Down
            // 
            this.Down.Description = "Down";
            this.Down.HeaderText = "";
            this.Down.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Down;
            this.Down.Name = "Down";
            this.Down.ReadOnly = true;
            this.Down.Width = 24;
            // 
            // Between
            // 
            this.Between.Description = "Between";
            this.Between.HeaderText = "";
            this.Between.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Between;
            this.Between.Name = "Between";
            this.Between.ReadOnly = true;
            this.Between.Width = 24;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رمز دو عاملی";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPassword)).EndInit();
            this.mnuPassword.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btnBackup;
        private System.Windows.Forms.ToolStripMenuItem btnRestore;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteDatabase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bsPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnShowSecretKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip mnuPassword;
        private System.Windows.Forms.ToolStripMenuItem btnShowPassword;
        private System.Windows.Forms.Button btnCopySecretKey;
        private System.Windows.Forms.ToolStripMenuItem btnCopyPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Timer timerClearPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnQrCodeSecretKey;
        private System.Windows.Forms.DataGridView grdPassword;
        private System.Windows.Forms.ToolStripMenuItem دریافترمزعبوردرزمانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnIsGetPasswordForShowSecretKey;
        private System.Windows.Forms.ToolStripMenuItem btnIsGetPasswordForShowDynamicPasswordKey;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.ToolStripMenuItem btnIsGetPasswordForRestoreBackup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordString;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counter;
        private System.Windows.Forms.DataGridViewImageColumn Up;
        private System.Windows.Forms.DataGridViewImageColumn Down;
        private System.Windows.Forms.DataGridViewImageColumn Between;
    }
}