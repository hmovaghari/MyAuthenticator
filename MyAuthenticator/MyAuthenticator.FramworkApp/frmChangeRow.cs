using MyAuthenticator.FramworkApp.Properties;
using MyAuthenticator.FramworkData.Context;
using MyAuthenticator.FramworkData.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAuthenticator.FramworkApp
{
    public partial class frmChangeRow : Form
    {
        public decimal RowNumber;

        public frmChangeRow(PasswordDTO passwordDTO)
        {
            InitializeComponent();
            var items = PasswordRepository.GetAnotherRowNumbers(passwordDTO.PasswordData);
            cmbRowNumber.Items.Clear();
            items.ForEach(i => cmbRowNumber.Items.Add(i.ToString()));
        }

        private void frmChangeRow_Load(object sender, EventArgs e)
        {
            if (cmbRowNumber.Items.Count == 0)
            {
                var isEnglish = Functions.IsEnglish();
                var text = isEnglish ? ResourcesEn.There_is_no_row_to_move : ResourcesFa.There_is_no_row_to_move;
                var caption = isEnglish ? ResourcesEn.Input_control : ResourcesFa.Input_control;
                MultiLanguageMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCancel_Click(null, null);
                return;
            }
            ChangeLanguageOfForm();
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
            lblRowNumber.RightToLeft = rightToLeft;
            Functions.ChangeDirection(pnlMoveRow, rightToLeft);
        }

        private void SetFormLanguage(bool isEnglish)
        {
            Text = isEnglish ? ResourcesEn.Move_row : ResourcesFa.Move_row;
            lblRowNumber.Text = (isEnglish ? ResourcesEn.Row_number : ResourcesFa.Row_number) + Functions.Colon;
        }

        private void SetToolTip(bool isEnglish)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnCancel, isEnglish ? ResourcesEn.Cancel_ : ResourcesFa.Cancel_);
            toolTip.SetToolTip(btnGetRowNumber, isEnglish ? ResourcesEn.Accept_ : ResourcesFa.Accept_);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGetRowNumber_Click(object sender, EventArgs e)
        {
            if (cmbRowNumber.SelectedIndex == -1 || cmbRowNumber.Text == "0")
            {
                var isEnglish = Functions.IsEnglish();
                var text = isEnglish ? ResourcesEn.RowNumber_is_empty : ResourcesFa.RowNumber_is_empty;
                var caption = isEnglish ? ResourcesEn.Input_control : ResourcesFa.Input_control;
                MultiLanguageMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RowNumber = Convert.ToDecimal(cmbRowNumber.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
