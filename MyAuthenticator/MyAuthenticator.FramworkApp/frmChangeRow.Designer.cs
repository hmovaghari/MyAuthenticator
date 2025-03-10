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
            this.lblRowNumber = new System.Windows.Forms.Label();
            this.cmbRowNumber = new System.Windows.Forms.ComboBox();
            this.pnlMoveRow = new System.Windows.Forms.Panel();
            this.pnlMoveRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Cancel1;
            this.btnCancel.Location = new System.Drawing.Point(40, 12);
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
            this.btnGetRowNumber.Image = global::MyAuthenticator.FramworkApp.Properties.Resources.Accept1;
            this.btnGetRowNumber.Location = new System.Drawing.Point(9, 12);
            this.btnGetRowNumber.Name = "btnGetRowNumber";
            this.btnGetRowNumber.Size = new System.Drawing.Size(25, 25);
            this.btnGetRowNumber.TabIndex = 16;
            this.btnGetRowNumber.Tag = "تائید";
            this.btnGetRowNumber.UseVisualStyleBackColor = true;
            this.btnGetRowNumber.Click += new System.EventHandler(this.btnGetRowNumber_Click);
            // 
            // lblRowNumber
            // 
            this.lblRowNumber.AutoSize = true;
            this.lblRowNumber.Location = new System.Drawing.Point(201, 18);
            this.lblRowNumber.Name = "lblRowNumber";
            this.lblRowNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRowNumber.Size = new System.Drawing.Size(68, 13);
            this.lblRowNumber.TabIndex = 18;
            this.lblRowNumber.Text = "شماره ردیف :";
            // 
            // cmbRowNumber
            // 
            this.cmbRowNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRowNumber.FormattingEnabled = true;
            this.cmbRowNumber.Location = new System.Drawing.Point(74, 14);
            this.cmbRowNumber.Name = "cmbRowNumber";
            this.cmbRowNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbRowNumber.Size = new System.Drawing.Size(121, 21);
            this.cmbRowNumber.TabIndex = 19;
            // 
            // pnlMoveRow
            // 
            this.pnlMoveRow.Controls.Add(this.lblRowNumber);
            this.pnlMoveRow.Controls.Add(this.btnCancel);
            this.pnlMoveRow.Controls.Add(this.btnGetRowNumber);
            this.pnlMoveRow.Controls.Add(this.cmbRowNumber);
            this.pnlMoveRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMoveRow.Location = new System.Drawing.Point(0, 0);
            this.pnlMoveRow.Name = "pnlMoveRow";
            this.pnlMoveRow.Size = new System.Drawing.Size(284, 51);
            this.pnlMoveRow.TabIndex = 20;
            // 
            // frmChangeRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 51);
            this.Controls.Add(this.pnlMoveRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChangeRow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جابجایی ردیف";
            this.Load += new System.EventHandler(this.frmChangeRow_Load);
            this.pnlMoveRow.ResumeLayout(false);
            this.pnlMoveRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetRowNumber;
        private System.Windows.Forms.Label lblRowNumber;
        private System.Windows.Forms.ComboBox cmbRowNumber;
        private System.Windows.Forms.Panel pnlMoveRow;
    }
}