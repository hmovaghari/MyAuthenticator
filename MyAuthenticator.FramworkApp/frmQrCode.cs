using MyAuthenticator.FramworkLibrary;
using System.Drawing;
using System.Windows.Forms;

namespace MyAuthenticator.FramworkApp
{
    public partial class frmQrCode : Form
    {
        public frmQrCode(string title, string code)
        {
            InitializeComponent();
            this.SetIcon();
            var url = TOTP.GenerateUrl(title, code);
            imgQrCode.Text = url;
            txtAboveBarcode.Text = title;
            txtBelowBarcode.Text = code;
            var size = new Size(imgQrCode.Image.Width + 50, Size.Height);
            Size = size;
        }
    }
}
