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

namespace MyAuthenticator.FramworkApp
{
    public partial class frmLogin : Form
    {
        private ChangePasswordMode ChangePasswordMode;

        public frmLogin(ChangePasswordMode changePasswordMode)
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnCancel, btnCancel.Tag.ToString());
            toolTip.SetToolTip(btnLogin, btnLogin.Tag.ToString());
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
                        RtlMessageBox.Show(Resources.Password_is_wrong,
                            Resources.Input_control,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private bool IsDataOK()
        {
            if (ChangePasswordMode == ChangePasswordMode.Change && !SettingRepository.IsLogin(txtOldPassword.Text))
            {
                RtlMessageBox.Show(Resources.Old_password_is_wrong,
                                    Resources.Input_control,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((ChangePasswordMode == ChangePasswordMode.Create || ChangePasswordMode == ChangePasswordMode.Change) && txtPassword.Text != txtRepeatPassword.Text)
            {
                RtlMessageBox.Show(Resources.Passwords_are_not_the_same,
                                    Resources.Input_control,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ChangePasswordMode == ChangePasswordMode.Login && string.IsNullOrEmpty(txtPassword.Text))
            {
                RtlMessageBox.Show(Resources.Password_not_entered,
                                    Resources.Input_control,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
