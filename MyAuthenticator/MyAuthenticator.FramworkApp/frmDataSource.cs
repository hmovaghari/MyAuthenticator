using MyAuthenticator.FramworkApp.Properties;
using MyAuthenticator.FramworkData.Context;
using MyAuthenticator.FramworkData.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAuthenticator.FramworkApp
{
    public partial class frmDataSource : Form
    {
        private Language? Language;
        public string OldPath { get; private set; }

        public frmDataSource(Language? language = null)
        {
            InitializeComponent();
            Language = language;
            OldPath = AuthenticatorRepository.GetUserDataSource();
            this.SetIcon();
            ChangeLanguage();
        }

        private void ChangeLanguage()
        {
            var toolTip = new ToolTip();
            switch (Language)
            {
                case FramworkData.Context.Language.English:
                    Text = ResourcesEn.Change_database_path;
                    toolTip.SetToolTip(btnDatabasePath, ResourcesEn.Database_path);
                    btnDatabasePath.Tag = ResourcesEn.Database_path;
                    toolTip.SetToolTip(btnChangePath, ResourcesEn.Change_database_path);
                    toolTip.SetToolTip(btnCancel, ResourcesEn.Cancel_);
                    Functions.ChangeDirection(pnlMain, RightToLeft.No);
                    break;
                case FramworkData.Context.Language.Farsi:
                    Text = ResourcesFa.Change_database_path;
                    toolTip.SetToolTip(btnDatabasePath, ResourcesFa.Database_path);
                    btnDatabasePath.Tag = ResourcesFa.Database_path;
                    toolTip.SetToolTip(btnChangePath, ResourcesFa.Change_database_path);
                    toolTip.SetToolTip(btnCancel, ResourcesFa.Cancel_);
                    Functions.ChangeDirection(pnlMain, RightToLeft.Yes);
                    break;
            }
        }

        private void btnDatabasePath_Click(object sender, EventArgs e)
        {
            saveDataSourceDialog.Title = btnDatabasePath.Tag.ToString();
            if (saveDataSourceDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = saveDataSourceDialog.FileName;
            }
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            if (ControEditPath())
            {
                AuthenticatorRepository.ChageUserDataSource(saveDataSourceDialog.FileName);
                DialogResult = DialogResult.OK;
            }
        }

        private bool ControEditPath()
        {
            if (string.IsNullOrEmpty(saveDataSourceDialog.FileName))
            {
                btnDatabasePath_Click(null, null);
                return false;
            }

            if (File.Exists(saveDataSourceDialog.FileName))
            {
                var message = Functions.IsEnglish() ? ResourcesEn.The_database_is_already_created : ResourcesFa.The_database_is_already_created;
                MultiLanguageMessageBox.Show(message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
