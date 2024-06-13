namespace MyAuthenticator.FramworkApp
{
    partial class frmDataSource
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
            this.pnlChangeDataSource = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDatabasePath = new System.Windows.Forms.Button();
            this.grpRadioBox = new System.Windows.Forms.GroupBox();
            this.rdbMoveDatabase = new System.Windows.Forms.RadioButton();
            this.rdbCreateOrCopyDatabase = new System.Windows.Forms.RadioButton();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.txtChangeTheDatabasePath = new System.Windows.Forms.RichTextBox();
            this.saveDataSourceDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlChangeDataSource.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpRadioBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChangeDataSource
            // 
            this.pnlChangeDataSource.Controls.Add(this.pnlMain);
            this.pnlChangeDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChangeDataSource.Location = new System.Drawing.Point(0, 0);
            this.pnlChangeDataSource.Name = "pnlChangeDataSource";
            this.pnlChangeDataSource.Size = new System.Drawing.Size(395, 102);
            this.pnlChangeDataSource.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.txtPath);
            this.pnlMain.Controls.Add(this.btnDatabasePath);
            this.pnlMain.Controls.Add(this.grpRadioBox);
            this.pnlMain.Controls.Add(this.btnChangePath);
            this.pnlMain.Controls.Add(this.txtChangeTheDatabasePath);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(395, 102);
            this.pnlMain.TabIndex = 7;
            // 
            // btnDatabasePath
            // 
            this.btnDatabasePath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabasePath.Location = new System.Drawing.Point(5, 18);
            this.btnDatabasePath.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDatabasePath.Name = "btnDatabasePath";
            this.btnDatabasePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDatabasePath.Size = new System.Drawing.Size(25, 25);
            this.btnDatabasePath.TabIndex = 5;
            this.btnDatabasePath.Tag = "مسیر پایگاه داده";
            this.btnDatabasePath.Text = "...";
            this.btnDatabasePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDatabasePath.UseVisualStyleBackColor = true;
            this.btnDatabasePath.Click += new System.EventHandler(this.btnDatabasePath_Click);
            // 
            // grpRadioBox
            // 
            this.grpRadioBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRadioBox.Controls.Add(this.rdbMoveDatabase);
            this.grpRadioBox.Controls.Add(this.rdbCreateOrCopyDatabase);
            this.grpRadioBox.Location = new System.Drawing.Point(116, 38);
            this.grpRadioBox.Name = "grpRadioBox";
            this.grpRadioBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpRadioBox.Size = new System.Drawing.Size(276, 58);
            this.grpRadioBox.TabIndex = 6;
            this.grpRadioBox.TabStop = false;
            // 
            // rdbMoveDatabase
            // 
            this.rdbMoveDatabase.AutoSize = true;
            this.rdbMoveDatabase.Location = new System.Drawing.Point(81, 37);
            this.rdbMoveDatabase.Name = "rdbMoveDatabase";
            this.rdbMoveDatabase.Size = new System.Drawing.Size(189, 17);
            this.rdbMoveDatabase.TabIndex = 1;
            this.rdbMoveDatabase.Text = "Move database - انتقال پایگاه داده";
            this.rdbMoveDatabase.UseVisualStyleBackColor = true;
            // 
            // rdbCreateOrCopyDatabase
            // 
            this.rdbCreateOrCopyDatabase.AutoSize = true;
            this.rdbCreateOrCopyDatabase.Checked = true;
            this.rdbCreateOrCopyDatabase.Location = new System.Drawing.Point(8, 9);
            this.rdbCreateOrCopyDatabase.Name = "rdbCreateOrCopyDatabase";
            this.rdbCreateOrCopyDatabase.Size = new System.Drawing.Size(262, 17);
            this.rdbCreateOrCopyDatabase.TabIndex = 0;
            this.rdbCreateOrCopyDatabase.TabStop = true;
            this.rdbCreateOrCopyDatabase.Text = "Create or copy database - کپی یا ایجاد پایگاه داده";
            this.rdbCreateOrCopyDatabase.UseVisualStyleBackColor = true;
            // 
            // btnChangePath
            // 
            this.btnChangePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangePath.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Accept1;
            this.btnChangePath.Location = new System.Drawing.Point(5, 71);
            this.btnChangePath.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangePath.Size = new System.Drawing.Size(25, 25);
            this.btnChangePath.TabIndex = 6;
            this.btnChangePath.Tag = "تغییر مسیر پایگاه داده";
            this.btnChangePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePath.UseVisualStyleBackColor = true;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // txtChangeTheDatabasePath
            // 
            this.txtChangeTheDatabasePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChangeTheDatabasePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangeTheDatabasePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtChangeTheDatabasePath.Location = new System.Drawing.Point(130, 5);
            this.txtChangeTheDatabasePath.Name = "txtChangeTheDatabasePath";
            this.txtChangeTheDatabasePath.ReadOnly = true;
            this.txtChangeTheDatabasePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChangeTheDatabasePath.Size = new System.Drawing.Size(262, 29);
            this.txtChangeTheDatabasePath.TabIndex = 0;
            this.txtChangeTheDatabasePath.Text = "Change the database path - تغییر مسیر پایگاه داده";
            // 
            // saveDataSourceDialog
            // 
            this.saveDataSourceDialog.Filter = "SQL Server Compact|*.sdf";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(38, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(354, 20);
            this.txtPath.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Cancel1;
            this.btnCancel.Location = new System.Drawing.Point(38, 71);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Tag = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 102);
            this.Controls.Add(this.pnlChangeDataSource);
            this.Name = "frmDataSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغییر مسیر پایگاه داده - Change the database path";
            this.pnlChangeDataSource.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpRadioBox.ResumeLayout(false);
            this.grpRadioBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChangeDataSource;
        private System.Windows.Forms.RichTextBox txtChangeTheDatabasePath;
        private System.Windows.Forms.SaveFileDialog saveDataSourceDialog;
        private System.Windows.Forms.GroupBox grpRadioBox;
        private System.Windows.Forms.Button btnDatabasePath;
        private System.Windows.Forms.RadioButton rdbMoveDatabase;
        private System.Windows.Forms.RadioButton rdbCreateOrCopyDatabase;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnCancel;
    }
}