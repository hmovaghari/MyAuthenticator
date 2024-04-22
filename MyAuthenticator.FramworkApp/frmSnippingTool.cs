using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyAuthenticator.FramworkApp
{
    public partial class frmSnippingTool : Form
    {
        public Image Image { get; set; }
        private Rectangle rcSelect = new Rectangle();
        private Point pntStart;
        private static float scaleFactor;

        public frmSnippingTool(Image screenShot)
        {
            InitializeComponent();
            this.SetIcon();
            this.BackgroundImage = screenShot;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
        }

        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,

            // http://pinvoke.net/default.aspx/gdi32/GetDeviceCaps.html
        }

        private static float getScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);

            g.ReleaseHdc(desktop);

            float ScreenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;

            return ScreenScalingFactor; // 1.25 = 125%
        }

        public static Image Snip()
        {
            scaleFactor = 1;
            var rc = Screen.PrimaryScreen.Bounds;
            scaleFactor = getScalingFactor();

            using (Bitmap bmp = new Bitmap((int)(rc.Width * scaleFactor), (int)(rc.Height * scaleFactor), System.Drawing.Imaging.PixelFormat.Format32bppPArgb))
            {
                using (Graphics gr = Graphics.FromImage(bmp))
                    gr.CopyFromScreen(0, 0, 0, 0, bmp.Size);
                using (var snipper = new frmSnippingTool(bmp))
                {
                    if (snipper.ShowDialog() == DialogResult.OK)
                    {
                        return snipper.Image;
                    }
                }
                return null;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            // Start the snip on mouse down
            if (e.Button != MouseButtons.Left) return;
            pntStart = e.Location;

            rcSelect = new Rectangle(e.Location, new Size(0, 0));
            this.Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            // Modify the selection on mouse move
            if (e.Button != MouseButtons.Left) return;

            int x1 = (int)Math.Min(e.X * scaleFactor, pntStart.X * scaleFactor);
            int y1 = (int)Math.Min(e.Y * scaleFactor, pntStart.Y * scaleFactor);
            int x2 = (int)Math.Max(e.X * scaleFactor, pntStart.X * scaleFactor);
            int y2 = (int)Math.Max(e.Y * scaleFactor, pntStart.Y * scaleFactor);

            rcSelect = new Rectangle(x1, y1, x2 - x1, y2 - y1);
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            // Complete the snip on mouse-up
            if (rcSelect.Width <= 0 || rcSelect.Height <= 0) return;
            Image = new Bitmap(rcSelect.Width, rcSelect.Height);
            using (Graphics gr = Graphics.FromImage(Image))
            {
                gr.DrawImage(this.BackgroundImage, new Rectangle(0, 0, Image.Width, Image.Height),
                    rcSelect, GraphicsUnit.Pixel);
            }
            DialogResult = DialogResult.OK;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw the current selection
            using (Brush br = new SolidBrush(Color.FromArgb(120, Color.White)))
            {
                int x1 = (int)(rcSelect.X / scaleFactor);
                int x2 = (int)((rcSelect.X + rcSelect.Width) / scaleFactor);
                int y1 = (int)(rcSelect.Y / scaleFactor);
                int y2 = (int)((rcSelect.Y + rcSelect.Height) / scaleFactor);

                e.Graphics.FillRectangle(br, new Rectangle(0, 0, x1, this.Height));
                e.Graphics.FillRectangle(br, new Rectangle(x2, 0, this.Width - x2, this.Height));
                e.Graphics.FillRectangle(br, new Rectangle(x1, 0, x2 - x1, y1));
                e.Graphics.FillRectangle(br, new Rectangle(x1, y2, x2 - x1, this.Height - y2));
            }
            using (Pen pen = new Pen(Color.Red, 3))
            {
                Rectangle newRectangle = new Rectangle((int)(rcSelect.X / scaleFactor), (int)(rcSelect.Y / scaleFactor), (int)(rcSelect.Width / scaleFactor), (int)(rcSelect.Height / scaleFactor));
                e.Graphics.DrawRectangle(pen, newRectangle);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Allow canceling the snip with the Escape key
            if (keyData == Keys.Escape) this.DialogResult = DialogResult.Cancel;
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
