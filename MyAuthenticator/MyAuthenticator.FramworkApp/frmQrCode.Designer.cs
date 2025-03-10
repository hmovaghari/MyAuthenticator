namespace MyAuthenticator.FramworkApp
{
    partial class frmQrCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQrCode));
            this.imgQrCode = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBelowBarcode = new System.Windows.Forms.TextBox();
            this.txtAboveBarcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgQrCode)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgQrCode
            // 
            this.imgQrCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgQrCode.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.imgQrCode.Image = ((System.Drawing.Image)(resources.GetObject("imgQrCode.Image")));
            this.imgQrCode.Location = new System.Drawing.Point(3, 24);
            this.imgQrCode.Name = "imgQrCode";
            this.imgQrCode.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.imgQrCode.Size = new System.Drawing.Size(226, 223);
            this.imgQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgQrCode.TabIndex = 1;
            this.imgQrCode.TabStop = false;
            this.imgQrCode.Text = "qrCodeImgControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtBelowBarcode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.imgQrCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAboveBarcode, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 273);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtBelowBarcode
            // 
            this.txtBelowBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBelowBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBelowBarcode.Location = new System.Drawing.Point(3, 253);
            this.txtBelowBarcode.Name = "txtBelowBarcode";
            this.txtBelowBarcode.ReadOnly = true;
            this.txtBelowBarcode.Size = new System.Drawing.Size(226, 13);
            this.txtBelowBarcode.TabIndex = 3;
            this.txtBelowBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAboveBarcode
            // 
            this.txtAboveBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAboveBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAboveBarcode.Location = new System.Drawing.Point(3, 3);
            this.txtAboveBarcode.Name = "txtAboveBarcode";
            this.txtAboveBarcode.ReadOnly = true;
            this.txtAboveBarcode.Size = new System.Drawing.Size(226, 13);
            this.txtAboveBarcode.TabIndex = 2;
            this.txtAboveBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmQrCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بارکد";
            ((System.ComponentModel.ISupportInitialize)(this.imgQrCode)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl imgQrCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAboveBarcode;
        private System.Windows.Forms.TextBox txtBelowBarcode;
    }
}