using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using MyAuthenticator.FramworkLibrary;
using DirectShowLib;
using MyAuthenticator.FramworkApp.Properties;
using MyAuthenticator.FramworkData.Context;

namespace MyAuthenticator.FramworkApp
{
    public partial class frmCamera : Form
    {
        private Capture _capture;
        public Dictionary<string, string> OTP = null;
        internal int CameraCount = 0;
        private int CameraIndex = 0;

        public frmCamera()
        {
            InitializeComponent();
            SetToolTip();
            this.SetIcon();
            CameraCount = CountConnectedCameras();
            if (CameraCount > 0)
            {
                btnChangeCamera.Enabled = CameraCount > 1;
                InitCapture(CameraIndex);
            }
        }

        private void SetToolTip()
        {
            ToolTip toolTip = new ToolTip();
            var isEnglish = Functions.IsEnglish();
            toolTip.SetToolTip(btnChangeCamera, isEnglish ? ResourcesEn.Change_camera : ResourcesFa.Change_camera);
        }

        public int CountConnectedCameras()
        {
            try
            {
                DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
                return _SystemCamereas.Count();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private void Streaming (object sender, EventArgs e)
        {
            var bitmap = (_capture.QueryFrame().ToImage<Bgr, byte>()).Bitmap;
            picCamera.Image = bitmap;
            var otp = TOTP.ReadOtp(bitmap);
            if (otp != null)
            {
                OTP = otp;
                DialogResult = DialogResult.OK;
            }
        }

        private void frmCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                CloseForm();
            }
        }

        private void btnChangeCamera_Click(object sender, EventArgs e)
        {
            CameraIndex = CameraIndex < (CameraCount - 1) ? ++CameraIndex : 0;
            InitCapture(CameraIndex);
        }

        private void InitCapture(Int32 _camIndex)
        {
            try
            {
                if (_capture != null)
                {
                    //_capture.Dispose();
                    _capture = null;
                    Application.Idle -= ProcessFrame;
                }

                _capture = new Capture(_camIndex);
                Application.Idle += ProcessFrame;
            }
            catch (Exception ex)
            {
                CloseForm();
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                var bitmap = Resources.CameraNotConnect1;
                try
                {
                    bitmap = (_capture.QueryFrame().ToImage<Bgr, byte>()).Bitmap;
                }
                catch (Exception ex) { }
                picCamera.Image = bitmap;
                var otp = TOTP.ReadOtp(bitmap);
                if (otp != null)
                {
                    OTP = otp;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                CloseForm();
            }
        }

        private void CloseForm()
        {
            Application.Idle -= ProcessFrame;
            _capture.Dispose();
            CameraCount = 0;
            CameraIndex = 0;
            DialogResult = DialogResult = DialogResult.Cancel;
        }

        internal void CloseCamera()
        {
            Application.Idle -= ProcessFrame;
            _capture.Dispose();
        }
    }
}
