using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAuthenticator.FramworkData.Repository;
using MyAuthenticator.FramworkData.Context;

namespace MyAuthenticator.FramworkApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Test
            Migration();
            InsertDefaultValue();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var isLoging = OpenLoginForm();
            if (isLoging)
            {
                Application.Run(new frmMain());
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public static bool OpenLoginForm()
        {
            var passwordMode = SettingRepository.GetPasswordMode();
            if (passwordMode == PasswordMode.Empty)
            {
                return true;
            }
            else
            {
                var changePasswordMode = passwordMode == PasswordMode.Null ? ChangePasswordMode.Create : ChangePasswordMode.Login;
                using (var frm = new frmLogin(changePasswordMode))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void InsertDefaultValue()
        {
            SettingRepository.InserDefaultValue();
        }

        public static void Migration()
        {
            AuthenticatorRepository.Migration();
        }
    }
}
