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
        public bool IsCopy { get; private set; }

        public frmDataSource(Language? language = null)
        {
            InitializeComponent();
            Language = language;
            this.SetIcon();
            ChangeLanguage();
            rdbMoveDatabase.Enabled = !(language == null);
        }

        private void ChangeLanguage()
        {
            var toolTip = new ToolTip();
            switch (Language)
            {
                case FramworkData.Context.Language.English:
                    Text = ResourcesEn.Change_the_database_path;
                    txtChangeTheDatabasePath.Text = ResourcesEn.Change_the_database_path;
                    rdbCreateOrCopyDatabase.Text = ResourcesEn.Create_or_copy_database;
                    rdbMoveDatabase.Text = ResourcesEn.Move_database;
                    toolTip.SetToolTip(btnDatabasePath, ResourcesEn.Database_path);
                    btnDatabasePath.Tag = ResourcesEn.Database_path;
                    toolTip.SetToolTip(btnChangePath, ResourcesEn.Change_the_database_path);
                    toolTip.SetToolTip(btnCancel, ResourcesEn.Cancel_);
                    Functions.ChangeDirection(pnlMain, RightToLeft.No);
                    break;
                case FramworkData.Context.Language.Farsi:
                    Text = ResourcesFa.Change_the_database_path;
                    txtChangeTheDatabasePath.Text = ResourcesFa.Change_the_database_path;
                    rdbCreateOrCopyDatabase.Text = ResourcesFa.Create_or_copy_database;
                    rdbMoveDatabase.Text = ResourcesFa.Move_database;
                    toolTip.SetToolTip(btnDatabasePath, ResourcesFa.Database_path);
                    btnDatabasePath.Tag = ResourcesFa.Database_path;
                    toolTip.SetToolTip(btnChangePath, ResourcesFa.Change_the_database_path);
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
                AuthenticatorRepository.ChageUserDataSource(txtPath.Text);
                IsCopy = rdbCreateOrCopyDatabase.Checked;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ControEditPath()
        {
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                btnDatabasePath_Click(null, null);
                return false;
            }

            if (!rdbCreateOrCopyDatabase.Checked && !rdbMoveDatabase.Checked)
            {
                grpRadioBox.ForeColor = Color.Red;
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
