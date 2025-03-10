namespace MyAuthenticator.FramworkApp
{
    partial class frmLogin
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnSupport = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Cancel1;
            this.btnCancel.Location = new System.Drawing.Point(39, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Tag = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Accept1;
            this.btnLogin.Location = new System.Drawing.Point(8, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(25, 25);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Tag = "ورود";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepeatPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtRepeatPassword.Location = new System.Drawing.Point(10, 43);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '*';
            this.txtRepeatPassword.Size = new System.Drawing.Size(198, 20);
            this.txtRepeatPassword.TabIndex = 13;
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRepeatPassword.Location = new System.Drawing.Point(210, 46);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRepeatPassword.Size = new System.Drawing.Size(85, 13);
            this.lblRepeatPassword.TabIndex = 12;
            this.lblRepeatPassword.Text = "تکرار کلمه عبور :";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPassword.Location = new System.Drawing.Point(10, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(198, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPassword.Location = new System.Drawing.Point(210, 13);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassword.Size = new System.Drawing.Size(58, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "کلمه عبور :";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtOldPassword.Location = new System.Drawing.Point(9, 75);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(198, 20);
            this.txtOldPassword.TabIndex = 17;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOldPassword.Location = new System.Drawing.Point(209, 78);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOldPassword.Size = new System.Drawing.Size(84, 13);
            this.lblOldPassword.TabIndex = 16;
            this.lblOldPassword.Text = "کلمه عبور قبلی :";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnSupport);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtOldPassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblOldPassword);
            this.pnlLogin.Controls.Add(this.lblRepeatPassword);
            this.pnlLogin.Controls.Add(this.btnCancel);
            this.pnlLogin.Controls.Add(this.txtRepeatPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(309, 140);
            this.pnlLogin.TabIndex = 18;
            // 
            // btnSupport
            // 
            this.btnSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSupport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSupport.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Question;
            this.btnSupport.Location = new System.Drawing.Point(70, 105);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(25, 25);
            this.btnSupport.TabIndex = 18;
            this.btnSupport.Tag = "پشتیبانی";
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(309, 140);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnSupport;
    }
}