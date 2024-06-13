using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAuthenticator.FramworkData.Repository;
using MyAuthenticator.FramworkData.Context;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using MyAuthenticator.FramworkApp.Properties;
using System.Data.Entity;
using System.IO;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CreateDatabaseIfNotExists();
            Migration();
            InsertDefaultValue();
            var isLoging = OpenLoginForm();
            if (isLoging)
            {
                var dialogResult = DialogResult.None;
                do
                {
                    using (var frm = new frmMain())
                    {
                        dialogResult = frm.ShowDialog();
                    }
                } while (dialogResult == DialogResult.Retry);
                //Application.Run(new frmMain());
            }
        }

        private static void CreateDatabaseIfNotExists()
        {
            var dataSource = AuthenticatorRepository.GetUserDataSource();
            if (string.IsNullOrEmpty(dataSource) || !File.Exists(dataSource))
            {
                using (var frm = new frmDataSource())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        dataSource = AuthenticatorRepository.GetUserDataSource();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            if (!string.IsNullOrEmpty(dataSource) && !File.Exists(dataSource))
            {
                AuthenticatorRepository.CreateDatabase();
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static bool OpenLoginForm()
        {
            var isLoadFromMainFuntion = new StackFrame(1, true).GetMethod().Name == "Main";
            if (isLoadFromMainFuntion)
            {
                Functions.LoadLanuage();
            }
            var isEnglish = Functions.IsEnglish();
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
                    if (!isLoadFromMainFuntion)
                    {
                        frm.Text = isEnglish ? ResourcesEn.Authentication : ResourcesFa.Authentication;
                    }
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
