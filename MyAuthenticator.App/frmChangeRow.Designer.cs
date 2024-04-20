namespace MyAuthenticator.FramworkApp
{
    partial class frmChangeRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeRow));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetRowNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRowNumber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(38, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Tag = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetRowNumber
            // 
            this.btnGetRowNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetRowNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGetRowNumber.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Continuation;
            this.btnGetRowNumber.Location = new System.Drawing.Point(7, 10);
            this.btnGetRowNumber.Name = "btnGetRowNumber";
            this.btnGetRowNumber.Size = new System.Drawing.Size(25, 25);
            this.btnGetRowNumber.TabIndex = 16;
            this.btnGetRowNumber.Tag = "ورود";
            this.btnGetRowNumber.UseVisualStyleBackColor = true;
            this.btnGetRowNumber.Click += new System.EventHandler(this.btnGetRowNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "شماره ردیف :";
            // 
            // cmbRowNumber
            // 
            this.cmbRowNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRowNumber.FormattingEnabled = true;
            this.cmbRowNumber.Location = new System.Drawing.Point(77, 12);
            this.cmbRowNumber.Name = "cmbRowNumber";
            this.cmbRowNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbRowNumber.Size = new System.Drawing.Size(121, 21);
            this.cmbRowNumber.TabIndex = 19;
            // 
            // frmChangeRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 47);
            this.Controls.Add(this.cmbRowNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetRowNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChangeRow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جابجایی ردیف";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetRowNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRowNumber;
    }
}