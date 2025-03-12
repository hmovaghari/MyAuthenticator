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
        private bool IsRunMoveDatabase;
        private DatabaseMoveType DatabaseMoveType;
        public string OldPath { get; private set; }

        public frmDataSource(bool isRunMoveDatabase, Language? language = null)
        {
            InitializeComponent();
            Language = language;
            OldPath = AuthenticatorRepository.GetUserDataSource();
            IsRunMoveDatabase = isRunMoveDatabase;
            DatabaseMoveType = IsRunMoveDatabase ? DatabaseMoveType.Move : DatabaseMoveType.Create;
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
            var message = Functions.IsEnglish() ? ResourcesEn.Create_Or_Move_Database : ResourcesFa.Create_Or_Move_Database;
            var dialogResult = !IsRunMoveDatabase ? MultiLanguageMessageBox.Show(message, string.Empty, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) : DialogResult.Yes;
            if (dialogResult == DialogResult.Yes && saveDataSourceDialog.ShowDialog() == DialogResult.OK)
            {
                openDataSourceDialog.FileName = string.Empty;
                txtPath.Text = saveDataSourceDialog.FileName;
            }
            else if (dialogResult == DialogResult.No && openDataSourceDialog.ShowDialog() == DialogResult.OK)
            {
                saveDataSourceDialog.FileName = string.Empty;
                txtPath.Text = openDataSourceDialog.FileName;
            }
            else
            {
                saveDataSourceDialog.FileName = string.Empty;
                openDataSourceDialog.FileName = string.Empty;
                txtPath.ResetText();
            }
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            if (ControEditPath())
            {
                if (!string.IsNullOrEmpty(saveDataSourceDialog.FileName))
                {
                    AuthenticatorRepository.ChageUserDataSource(saveDataSourceDialog.FileName);
                }
                else if (!string.IsNullOrEmpty(openDataSourceDialog.FileName))
                {
                    AuthenticatorRepository.ChageUserDataSource(openDataSourceDialog.FileName);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ControEditPath()
        {
            if (IsRunMoveDatabase)
            {
                if (File.Exists(saveDataSourceDialog.FileName))
                {
                    var message = Functions.IsEnglish() ? ResourcesEn.The_database_is_already_created : ResourcesFa.The_database_is_already_created;
                    MultiLanguageMessageBox.Show(message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (DatabaseMoveType == DatabaseMoveType.Create && File.Exists(saveDataSourceDialog.FileName))
                {
                    var message = Functions.IsEnglish() ? ResourcesEn.The_database_is_already_created : ResourcesFa.The_database_is_already_created;
                    MultiLanguageMessageBox.Show(message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (DatabaseMoveType == DatabaseMoveType.Move && !File.Exists(openDataSourceDialog.FileName))
                {
                    var message = Functions.IsEnglish() ? ResourcesEn.The_database_file_does_not_exist : ResourcesFa.The_database_file_does_not_exist;
                    MultiLanguageMessageBox.Show(message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
