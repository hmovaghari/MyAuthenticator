using MyAuthenticator.FramworkApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAuthenticator.FramworkData.Repository;
using MyAuthenticator.FramworkData.Context;

namespace MyAuthenticator.FramworkApp
{
    public partial class frmLogin : Form
    {
        private ChangePasswordMode ChangePasswordMode;

        public frmLogin(ChangePasswordMode changePasswordMode)
        {
            InitializeComponent();
            this.SetIcon();
            ChangeLanguageOfForm();
            ChangePasswordMode = changePasswordMode;
            var isCreateOrChange = ChangePasswordMode == ChangePasswordMode.Create || changePasswordMode == ChangePasswordMode.Change;
            var isChange = changePasswordMode == ChangePasswordMode.Change;
            txtRepeatPassword.Visible = isCreateOrChange;
            lblRepeatPassword.Visible = isCreateOrChange;
            txtOldPassword.Visible = isChange;
            lblOldPassword.Visible = isChange;
            var size = new Size();
            size.Width = 325;
            if (changePasswordMode == ChangePasswordMode.Create)
            {
                size.Height = 147;
            }
            else if (changePasswordMode == ChangePasswordMode.Login)
            {
                size.Height = 115;
            }
            else if (changePasswordMode == ChangePasswordMode.Change)
            {
                size.Height = 179;
            }
            Size = size;
            MaximumSize = size;
            MinimumSize = size;
        }

        private void ChangeLanguageOfForm()
        {
            bool isEnglish = Functions.IsEnglish();
            SetToolTip(isEnglish);
            SetFormLanguage(isEnglish);
            ChangeFormDirection(isEnglish);
        }

        private void ChangeFormDirection(bool isEnglish)
        {
            var rightToLeft = isEnglish ? RightToLeft.No : RightToLeft.Yes;
            lblPassword.RightToLeft = rightToLeft;
            lblRepeatPassword.RightToLeft = rightToLeft;
            lblOldPassword.RightToLeft = rightToLeft;
            Functions.ChangeDirection(pnlLogin, rightToLeft);
        }

        private void SetFormLanguage(bool isEnglish)
        {
            if (ChangePasswordMode != ChangePasswordMode.Change)
            {
                Text = isEnglish ? ResourcesEn.Login : ResourcesFa.Login;
            }
            lblPassword.Text = (isEnglish ? ResourcesEn.Password_ : ResourcesFa.Password_) + Functions.Colon;
            lblRepeatPassword.Text = (isEnglish ? ResourcesEn.Repeat_password : ResourcesFa.Repeat_password) + Functions.Colon;
            lblOldPassword.Text = (isEnglish ? ResourcesEn.Previous_password : ResourcesFa.Previous_password) + Functions.Colon;
        }

        private void SetToolTip(bool isEnglish)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnCancel, isEnglish ? ResourcesEn.Cancel_ : ResourcesFa.Cancel_);
            toolTip.SetToolTip(btnLogin, isEnglish ? ResourcesEn.Login : ResourcesFa.Login);
            toolTip.SetToolTip(btnSupport, isEnglish ? ResourcesEn.Support : ResourcesFa.Support);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsDataOK())
            {
                if (ChangePasswordMode == ChangePasswordMode.Create || ChangePasswordMode == ChangePasswordMode.Change)
                {
                    SettingRepository.UpdatePassword(txtPassword.Text);
                    DialogResult = DialogResult.OK;
                }
                else if (ChangePasswordMode == ChangePasswordMode.Login)
                {
                    var isLogin = SettingRepository.IsLogin(txtPassword.Text);
                    if (isLogin)
                    {
                        DialogResult = DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        var isEnglish = Functions.IsEnglish();
                        var text = isEnglish ? ResourcesEn.Password_is_wrong : ResourcesFa.Password_is_wrong;
                        var caption = isEnglish ? ResourcesEn.Input_control : ResourcesFa.Input_control;
                        MultiLanguageMessageBox.Show(text,caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private bool IsDataOK()
        {
            var isEnglish = Functions.IsEnglish();
            var text = string.Empty;
            var caption = isEnglish ? ResourcesEn.Input_control : ResourcesFa.Input_control;
            if (ChangePasswordMode == ChangePasswordMode.Change && !SettingRepository.IsLogin(txtOldPassword.Text))
            {
                text = isEnglish ? ResourcesEn.Previous_password_is_wrong : ResourcesFa.Previous_password_is_wrong;
                MultiLanguageMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((ChangePasswordMode == ChangePasswordMode.Create || ChangePasswordMode == ChangePasswordMode.Change) && txtPassword.Text != txtRepeatPassword.Text)
            {
                text = isEnglish ? ResourcesEn.Passwords_are_not_the_same : ResourcesFa.Passwords_are_not_the_same;
                MultiLanguageMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ChangePasswordMode == ChangePasswordMode.Login && string.IsNullOrEmpty(txtPassword.Text))
            {
                text = isEnglish ? ResourcesEn.Password_not_entered : ResourcesFa.Password_not_entered;
                MultiLanguageMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            frmMain.OpenSupport();
        }
    }
}
