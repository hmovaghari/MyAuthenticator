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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCheckAuthenticationWhen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIsGetPasswordForShowSecretKey = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIsGetPasswordForShowDynamicPasswordKey = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIsGetPasswordForRestoreBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripChangeLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCheckUpdateSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.btntoolStripCheckUpdateTrue = new System.Windows.Forms.ToolStripMenuItem();
            this.btntoolStripCheckUpdateFalse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDatabase = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnOpenDatabasePath = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeDatabasePath = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSupport = new System.Windows.Forms.ToolStripButton();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetOtpFromCamera = new System.Windows.Forms.Button();
            this.btnGetOtpFromSnip = new System.Windows.Forms.Button();
            this.btnGetOtpFromFile = new System.Windows.Forms.Button();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.btnQrCodeSecretKey = new System.Windows.Forms.Button();
            this.btnCopySecretKey = new System.Windows.Forms.Button();
            this.btnShowSecretKey = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdPassword = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuPassword = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Between = new System.Windows.Forms.DataGridViewImageColumn();
            this.passwordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretKeyDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.passwordStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPassword = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerClearPassword = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBackupDialog = new System.Windows.Forms.SaveFileDialog();
            this.openBackupDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPassword)).BeginInit();
            this.mnuPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPassword)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStripMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlCrud, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.grdPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnlSearch, 0, 2);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSettings,
            this.toolStripDatabase,
            this.btnSupport});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenu.Size = new System.Drawing.Size(645, 25);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.toolStripCheckAuthenticationWhen,
            this.toolStripChangeLanguage,
            this.toolStripCheckUpdateSetting,
            this.toolStripCheckUpdate});
            this.toolStripSettings.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Settings1;
            this.toolStripSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(79, 22);
            this.toolStripSettings.Text = "تنظیمات";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password1;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(194, 22);
            this.btnChangePassword.Text = "تغییر رمز عبور";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // toolStripCheckAuthenticationWhen
            // 
            this.toolStripCheckAuthenticationWhen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIsGetPasswordForShowSecretKey,
            this.btnIsGetPasswordForShowDynamicPasswordKey,
            this.btnIsGetPasswordForRestoreBackup});
            this.toolStripCheckAuthenticationWhen.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password1;
            this.toolStripCheckAuthenticationWhen.Name = "toolStripCheckAuthenticationWhen";
            this.toolStripCheckAuthenticationWhen.Size = new System.Drawing.Size(194, 22);
            this.toolStripCheckAuthenticationWhen.Text = "دریافت رمز عبور در زمان";
            // 
            // btnIsGetPasswordForShowSecretKey
            // 
            this.btnIsGetPasswordForShowSecretKey.Name = "btnIsGetPasswordForShowSecretKey";
            this.btnIsGetPasswordForShowSecretKey.Size = new System.Drawing.Size(285, 22);
            this.btnIsGetPasswordForShowSecretKey.Text = "نمایش کد امنیتی";
            this.btnIsGetPasswordForShowSecretKey.Click += new System.EventHandler(this.btnIsGetPasswordForShowSecretKey_Click);
            // 
            // btnIsGetPasswordForShowDynamicPasswordKey
            // 
            this.btnIsGetPasswordForShowDynamicPasswordKey.Name = "btnIsGetPasswordForShowDynamicPasswordKey";
            this.btnIsGetPasswordForShowDynamicPasswordKey.Size = new System.Drawing.Size(285, 22);
            this.btnIsGetPasswordForShowDynamicPasswordKey.Text = "نمایش کلمه عبور پویا";
            this.btnIsGetPasswordForShowDynamicPasswordKey.Click += new System.EventHandler(this.btnIsGetPasswordForShowDynamicPasswordKey_Click);
            // 
            // btnIsGetPasswordForRestoreBackup
            // 
            this.btnIsGetPasswordForRestoreBackup.Name = "btnIsGetPasswordForRestoreBackup";
            this.btnIsGetPasswordForRestoreBackup.Size = new System.Drawing.Size(285, 22);
            this.btnIsGetPasswordForRestoreBackup.Text = "دریافت/بازیابی یا تغییر مسیر نسخه پشتیبان";
            this.btnIsGetPasswordForRestoreBackup.Click += new System.EventHandler(this.btnIsGetPasswordForRestoreBackup_Click);
            // 
            // toolStripChangeLanguage
            // 
            this.toolStripChangeLanguage.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Language1;
            this.toolStripChangeLanguage.Name = "toolStripChangeLanguage";
            this.toolStripChangeLanguage.Size = new System.Drawing.Size(194, 22);
            this.toolStripChangeLanguage.Text = "تغییر زبان";
            // 
            // toolStripCheckUpdateSetting
            // 
            this.toolStripCheckUpdateSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntoolStripCheckUpdateTrue,
            this.btntoolStripCheckUpdateFalse});
            this.toolStripCheckUpdateSetting.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Update;
            this.toolStripCheckUpdateSetting.Name = "toolStripCheckUpdateSetting";
            this.toolStripCheckUpdateSetting.Size = new System.Drawing.Size(194, 22);
            this.toolStripCheckUpdateSetting.Text = "بررسی آپدیت هنگام شروع";
            // 
            // btntoolStripCheckUpdateTrue
            // 
            this.btntoolStripCheckUpdateTrue.Name = "btntoolStripCheckUpdateTrue";
            this.btntoolStripCheckUpdateTrue.Size = new System.Drawing.Size(90, 22);
            this.btntoolStripCheckUpdateTrue.Text = "بله";
            this.btntoolStripCheckUpdateTrue.Click += new System.EventHandler(this.ChangeIsCheckUpdate);
            // 
            // btntoolStripCheckUpdateFalse
            // 
            this.btntoolStripCheckUpdateFalse.Name = "btntoolStripCheckUpdateFalse";
            this.btntoolStripCheckUpdateFalse.Size = new System.Drawing.Size(90, 22);
            this.btntoolStripCheckUpdateFalse.Text = "خیر";
            this.btntoolStripCheckUpdateFalse.Click += new System.EventHandler(this.ChangeIsCheckUpdate);
            // 
            // toolStripCheckUpdate
            // 
            this.toolStripCheckUpdate.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Update;
            this.toolStripCheckUpdate.Name = "toolStripCheckUpdate";
            this.toolStripCheckUpdate.Size = new System.Drawing.Size(194, 22);
            this.toolStripCheckUpdate.Text = "بررسی آپدیت";
            this.toolStripCheckUpdate.Click += new System.EventHandler(this.CheckUpdate);
            // 
            // toolStripDatabase
            // 
            this.toolStripDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenDatabasePath,
            this.btnChangeDatabasePath,
            this.btnBackup,
            this.btnRestore,
            this.btnDeleteDatabase});
            this.toolStripDatabase.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Database1;
            this.toolStripDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDatabase.Name = "toolStripDatabase";
            this.toolStripDatabase.Size = new System.Drawing.Size(86, 22);
            this.toolStripDatabase.Text = "پایگاه داده";
            // 
            // btnOpenDatabasePath
            // 
            this.btnOpenDatabasePath.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.OpenDatabasePath;
            this.btnOpenDatabasePath.Name = "btnOpenDatabasePath";
            this.btnOpenDatabasePath.Size = new System.Drawing.Size(195, 22);
            this.btnOpenDatabasePath.Text = "باز کردن مسیر پایگاه داده";
            this.btnOpenDatabasePath.Click += new System.EventHandler(this.btnOpenDatabasePath_Click);
            // 
            // btnChangeDatabasePath
            // 
            this.btnChangeDatabasePath.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.DatabasePath;
            this.btnChangeDatabasePath.Name = "btnChangeDatabasePath";
            this.btnChangeDatabasePath.Size = new System.Drawing.Size(195, 22);
            this.btnChangeDatabasePath.Text = "تغییر مسیر پایگاه داده";
            this.btnChangeDatabasePath.Click += new System.EventHandler(this.btnChangeDatabasePath_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Backup1;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(195, 22);
            this.btnBackup.Text = "دریافت نسخه پشتیبان";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Restore1;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(195, 22);
            this.btnRestore.Text = "بازیابی نسخه پشتیبان";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDeleteDatabase
            // 
            this.btnDeleteDatabase.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.DeleteDatabase1;
            this.btnDeleteDatabase.Name = "btnDeleteDatabase";
            this.btnDeleteDatabase.Size = new System.Drawing.Size(195, 22);
            this.btnDeleteDatabase.Text = "پاک کردن پایگاه داده";
            this.btnDeleteDatabase.Click += new System.EventHandler(this.btnDeleteDatabase_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Question;
            this.btnSupport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(70, 22);
            this.btnSupport.Text = "پشتیبانی";
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.lblSecretKey);
            this.pnlData.Controls.Add(this.lblName);
            this.pnlData.Controls.Add(this.txtName);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.tableLayoutPanel2);
            this.pnlData.Controls.Add(this.btnQrCodeSecretKey);
            this.pnlData.Controls.Add(this.btnCopySecretKey);
            this.pnlData.Controls.Add(this.btnShowSecretKey);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(4, 31);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4);
            this.pnlData.Name = "pnlData";
            this.pnlData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlData.Size = new System.Drawing.Size(637, 86);
            this.pnlData.TabIndex = 13;
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(553, 50);
            this.lblSecretKey.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(67, 19);
            this.lblSecretKey.TabIndex = 6;
            this.lblSecretKey.Text = "کد امنیتی :";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(553, 14);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 19);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "نام :";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(8, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(529, 27);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(541, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "*";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.btnGetOtpFromCamera, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGetOtpFromSnip, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGetOtpFromFile, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSecretKey, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(152, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(390, 40);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // btnGetOtpFromCamera
            // 
            this.btnGetOtpFromCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGetOtpFromCamera.Enabled = false;
            this.btnGetOtpFromCamera.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.CameraCapture1;
            this.btnGetOtpFromCamera.Location = new System.Drawing.Point(5, 6);
            this.btnGetOtpFromCamera.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGetOtpFromCamera.Name = "btnGetOtpFromCamera";
            this.btnGetOtpFromCamera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetOtpFromCamera.Size = new System.Drawing.Size(30, 28);
            this.btnGetOtpFromCamera.TabIndex = 15;
            this.btnGetOtpFromCamera.Tag = "خواندن بارکد از دوربین";
            this.btnGetOtpFromCamera.UseVisualStyleBackColor = true;
            this.btnGetOtpFromCamera.Click += new System.EventHandler(this.btnGetOtpFromCamera_Click);
            // 
            // btnGetOtpFromSnip
            // 
            this.btnGetOtpFromSnip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGetOtpFromSnip.Enabled = false;
            this.btnGetOtpFromSnip.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.ScreenCapture1;
            this.btnGetOtpFromSnip.Location = new System.Drawing.Point(45, 6);
            this.btnGetOtpFromSnip.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGetOtpFromSnip.Name = "btnGetOtpFromSnip";
            this.btnGetOtpFromSnip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetOtpFromSnip.Size = new System.Drawing.Size(30, 28);
            this.btnGetOtpFromSnip.TabIndex = 14;
            this.btnGetOtpFromSnip.Tag = "خواندن بارکد از صفحه نمایش";
            this.btnGetOtpFromSnip.UseVisualStyleBackColor = true;
            this.btnGetOtpFromSnip.Click += new System.EventHandler(this.btnGetOtpFromSnip_Click);
            // 
            // btnGetOtpFromFile
            // 
            this.btnGetOtpFromFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGetOtpFromFile.Enabled = false;
            this.btnGetOtpFromFile.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.FileReader1;
            this.btnGetOtpFromFile.Location = new System.Drawing.Point(85, 6);
            this.btnGetOtpFromFile.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGetOtpFromFile.Name = "btnGetOtpFromFile";
            this.btnGetOtpFromFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetOtpFromFile.Size = new System.Drawing.Size(30, 28);
            this.btnGetOtpFromFile.TabIndex = 13;
            this.btnGetOtpFromFile.Tag = "خواندن بارکد از فایل";
            this.btnGetOtpFromFile.UseVisualStyleBackColor = true;
            this.btnGetOtpFromFile.Click += new System.EventHandler(this.btnGetOtpFromFile_Click);
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecretKey.Enabled = false;
            this.txtSecretKey.Location = new System.Drawing.Point(125, 6);
            this.txtSecretKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(260, 27);
            this.txtSecretKey.TabIndex = 7;
            // 
            // btnQrCodeSecretKey
            // 
            this.btnQrCodeSecretKey.BackgroundImage = global::MyAuthenticator.FramworkApp.Properties.Resources.QrCode1;
            this.btnQrCodeSecretKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQrCodeSecretKey.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password1;
            this.btnQrCodeSecretKey.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQrCodeSecretKey.Location = new System.Drawing.Point(8, 47);
            this.btnQrCodeSecretKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnQrCodeSecretKey.Name = "btnQrCodeSecretKey";
            this.btnQrCodeSecretKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnQrCodeSecretKey.Size = new System.Drawing.Size(42, 27);
            this.btnQrCodeSecretKey.TabIndex = 12;
            this.btnQrCodeSecretKey.Tag = "نمایش بارکد کد امنیتی";
            this.btnQrCodeSecretKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQrCodeSecretKey.UseVisualStyleBackColor = true;
            this.btnQrCodeSecretKey.Click += new System.EventHandler(this.btnQrCodeSecretKey_Click);
            // 
            // btnCopySecretKey
            // 
            this.btnCopySecretKey.BackgroundImage = global::MyAuthenticator.FramworkApp.Properties.Resources.Copy1;
            this.btnCopySecretKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCopySecretKey.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password1;
            this.btnCopySecretKey.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopySecretKey.Location = new System.Drawing.Point(57, 47);
            this.btnCopySecretKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCopySecretKey.Name = "btnCopySecretKey";
            this.btnCopySecretKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCopySecretKey.Size = new System.Drawing.Size(42, 27);
            this.btnCopySecretKey.TabIndex = 11;
            this.btnCopySecretKey.Tag = "کپی کد امنیتی";
            this.btnCopySecretKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopySecretKey.UseVisualStyleBackColor = true;
            this.btnCopySecretKey.Click += new System.EventHandler(this.btnCopySecretKey_Click);
            // 
            // btnShowSecretKey
            // 
            this.btnShowSecretKey.BackgroundImage = global::MyAuthenticator.FramworkApp.Properties.Resources.Show1;
            this.btnShowSecretKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowSecretKey.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password1;
            this.btnShowSecretKey.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowSecretKey.Location = new System.Drawing.Point(106, 47);
            this.btnShowSecretKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnShowSecretKey.Name = "btnShowSecretKey";
            this.btnShowSecretKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnShowSecretKey.Size = new System.Drawing.Size(42, 27);
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
            this.label4.Location = new System.Drawing.Point(541, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // pnlCrud
            // 
            this.pnlCrud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCrud.Controls.Add(this.btnCancel);
            this.pnlCrud.Controls.Add(this.btnAcc);
            this.pnlCrud.Controls.Add(this.btnDelete);
            this.pnlCrud.Controls.Add(this.btnEdit);
            this.pnlCrud.Controls.Add(this.btnAdd);
            this.pnlCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCrud.Location = new System.Drawing.Point(5, 323);
            this.pnlCrud.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(635, 40);
            this.pnlCrud.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Cancel1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(42, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.btnAcc.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Accept1;
            this.btnAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcc.Location = new System.Drawing.Point(7, 7);
            this.btnAcc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.btnDelete.Location = new System.Drawing.Point(530, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.btnEdit.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Edit1;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(565, 7);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.btnAdd.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Add1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(600, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.Between,
            this.passwordIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.secretKeyDataGridViewImageColumn,
            this.passwordStringDataGridViewTextBoxColumn,
            this.rowNumberDataGridViewTextBoxColumn,
            this.counterDataGridViewTextBoxColumn,
            this.passwordDataDataGridViewTextBoxColumn});
            this.grdPassword.DataSource = this.bsPassword;
            this.grdPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPassword.Location = new System.Drawing.Point(4, 171);
            this.grdPassword.Margin = new System.Windows.Forms.Padding(4);
            this.grdPassword.Name = "grdPassword";
            this.grdPassword.ReadOnly = true;
            this.grdPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdPassword.Size = new System.Drawing.Size(637, 142);
            this.grdPassword.TabIndex = 12;
            this.grdPassword.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPassword_CellContentDoubleClick);
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
            // mnuPassword
            // 
            this.mnuPassword.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowPassword,
            this.btnCopyPassword});
            this.mnuPassword.Name = "mnuPassword";
            this.mnuPassword.Size = new System.Drawing.Size(179, 48);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password1;
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(178, 22);
            this.btnShowPassword.Text = "نمایش کلمه عبور پویا";
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Password1;
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(178, 22);
            this.btnCopyPassword.Text = "کپی کلمه عبور پویا";
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
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
            this.Up.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Up1;
            this.Up.Name = "Up";
            this.Up.ReadOnly = true;
            this.Up.Width = 24;
            // 
            // Down
            // 
            this.Down.Description = "Down";
            this.Down.HeaderText = "";
            this.Down.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Down1;
            this.Down.Name = "Down";
            this.Down.ReadOnly = true;
            this.Down.Width = 24;
            // 
            // Between
            // 
            this.Between.Description = "Between";
            this.Between.HeaderText = "";
            this.Between.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Between1;
            this.Between.Name = "Between";
            this.Between.ReadOnly = true;
            this.Between.Width = 24;
            // 
            // passwordIDDataGridViewTextBoxColumn
            // 
            this.passwordIDDataGridViewTextBoxColumn.DataPropertyName = "PasswordID";
            this.passwordIDDataGridViewTextBoxColumn.HeaderText = "PasswordID";
            this.passwordIDDataGridViewTextBoxColumn.Name = "passwordIDDataGridViewTextBoxColumn";
            this.passwordIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secretKeyDataGridViewImageColumn
            // 
            this.secretKeyDataGridViewImageColumn.DataPropertyName = "SecretKey";
            this.secretKeyDataGridViewImageColumn.HeaderText = "SecretKey";
            this.secretKeyDataGridViewImageColumn.Name = "secretKeyDataGridViewImageColumn";
            this.secretKeyDataGridViewImageColumn.ReadOnly = true;
            // 
            // passwordStringDataGridViewTextBoxColumn
            // 
            this.passwordStringDataGridViewTextBoxColumn.DataPropertyName = "PasswordString";
            this.passwordStringDataGridViewTextBoxColumn.HeaderText = "PasswordString";
            this.passwordStringDataGridViewTextBoxColumn.Name = "passwordStringDataGridViewTextBoxColumn";
            this.passwordStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowNumberDataGridViewTextBoxColumn
            // 
            this.rowNumberDataGridViewTextBoxColumn.DataPropertyName = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.HeaderText = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.Name = "rowNumberDataGridViewTextBoxColumn";
            this.rowNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // counterDataGridViewTextBoxColumn
            // 
            this.counterDataGridViewTextBoxColumn.DataPropertyName = "Counter";
            this.counterDataGridViewTextBoxColumn.HeaderText = "Counter";
            this.counterDataGridViewTextBoxColumn.Name = "counterDataGridViewTextBoxColumn";
            this.counterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataDataGridViewTextBoxColumn
            // 
            this.passwordDataDataGridViewTextBoxColumn.DataPropertyName = "PasswordData";
            this.passwordDataDataGridViewTextBoxColumn.HeaderText = "PasswordData";
            this.passwordDataDataGridViewTextBoxColumn.Name = "passwordDataDataGridViewTextBoxColumn";
            this.passwordDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPassword
            // 
            this.bsPassword.DataSource = typeof(MyAuthenticator.FramworkApp.PasswordDTO);
            this.bsPassword.CurrentChanged += new System.EventHandler(this.bsPassword_CurrentChanged);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.lblSearchName);
            this.pnlSearch.Controls.Add(this.txtNameSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(4, 125);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlSearch.Size = new System.Drawing.Size(637, 38);
            this.pnlSearch.TabIndex = 14;
            // 
            // lblSearchName
            // 
            this.lblSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(553, 7);
            this.lblSearchName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(60, 19);
            this.lblSearchName.TabIndex = 9;
            this.lblSearchName.Text = "جستجو :";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSearch.Location = new System.Drawing.Point(8, 4);
            this.txtNameSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(529, 27);
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
            // saveBackupDialog
            // 
            this.saveBackupDialog.Filter = "SQL Server Backup|*.sqlbak";
            // 
            // openBackupDialog
            // 
            this.openBackupDialog.Filter = "SQL Server Backup|*.sqlbak";
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PasswordData";
            this.dataGridViewTextBoxColumn3.HeaderText = "PasswordData";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png;";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعتبارسنجی دوعاملی";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlCrud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPassword)).EndInit();
            this.mnuPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsPassword)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDatabase;
        private System.Windows.Forms.ToolStripMenuItem btnBackup;
        private System.Windows.Forms.ToolStripMenuItem btnRestore;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteDatabase;
        private System.Windows.Forms.Panel pnlCrud;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bsPassword;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSecretKey;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnShowSecretKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip mnuPassword;
        private System.Windows.Forms.ToolStripMenuItem btnShowPassword;
        private System.Windows.Forms.Button btnCopySecretKey;
        private System.Windows.Forms.ToolStripMenuItem btnCopyPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Timer timerClearPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.SaveFileDialog saveBackupDialog;
        private System.Windows.Forms.OpenFileDialog openBackupDialog;
        private System.Windows.Forms.Button btnQrCodeSecretKey;
        private System.Windows.Forms.DataGridView grdPassword;
        private System.Windows.Forms.ToolStripMenuItem toolStripCheckAuthenticationWhen;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn secretKeyDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnGetOtpFromFile;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Button btnGetOtpFromSnip;
        private System.Windows.Forms.Button btnGetOtpFromCamera;
        private System.Windows.Forms.ToolStripMenuItem toolStripChangeLanguage;
        private System.Windows.Forms.ToolStripButton btnSupport;
        private System.Windows.Forms.ToolStripMenuItem toolStripCheckUpdateSetting;
        private System.Windows.Forms.ToolStripMenuItem btntoolStripCheckUpdateTrue;
        private System.Windows.Forms.ToolStripMenuItem btntoolStripCheckUpdateFalse;
        private System.Windows.Forms.ToolStripMenuItem toolStripCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnChangeDatabasePath;
        private System.Windows.Forms.ToolStripMenuItem btnOpenDatabasePath;
    }
}