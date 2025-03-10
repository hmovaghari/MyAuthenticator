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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDatabasePath = new System.Windows.Forms.Button();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.saveDataSourceDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlChangeDataSource.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChangeDataSource
            // 
            this.pnlChangeDataSource.Controls.Add(this.pnlMain);
            this.pnlChangeDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChangeDataSource.Location = new System.Drawing.Point(0, 0);
            this.pnlChangeDataSource.Name = "pnlChangeDataSource";
            this.pnlChangeDataSource.Size = new System.Drawing.Size(395, 41);
            this.pnlChangeDataSource.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.txtPath);
            this.pnlMain.Controls.Add(this.btnDatabasePath);
            this.pnlMain.Controls.Add(this.btnChangePath);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(395, 41);
            this.pnlMain.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Cancel1;
            this.btnCancel.Location = new System.Drawing.Point(43, 8);
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
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(111, 11);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(277, 20);
            this.txtPath.TabIndex = 7;
            // 
            // btnDatabasePath
            // 
            this.btnDatabasePath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabasePath.Location = new System.Drawing.Point(75, 8);
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
            // btnChangePath
            // 
            this.btnChangePath.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Accept1;
            this.btnChangePath.Location = new System.Drawing.Point(8, 8);
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
            // saveDataSourceDialog
            // 
            this.saveDataSourceDialog.Filter = "SQL Server Compact|*.sdf";
            // 
            // frmDataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 41);
            this.Controls.Add(this.pnlChangeDataSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 80);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(411, 80);
            this.Name = "frmDataSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغییر مسیر پایگاه داده - Change the database path";
            this.pnlChangeDataSource.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChangeDataSource;
        private System.Windows.Forms.SaveFileDialog saveDataSourceDialog;
        private System.Windows.Forms.Button btnDatabasePath;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnCancel;
    }
}