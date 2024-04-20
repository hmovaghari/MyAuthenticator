using MyAuthenticator.FramworkApp.Properties;
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
            items.ForEach(i => cmbRowNumber.Items.Add(cmbRowNumber.Items.Add(i.ToString())));
            if (cmbRowNumber.Items.Count == 0)
            {
                RtlMessageBox.Show(Resources.There_is_no_row_to_change,
                            Resources.Input_control,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnGetRowNumber_Click(object sender, EventArgs e)
        {
            if (cmbRowNumber.SelectedIndex == -1 || cmbRowNumber.Text == "0")
            {
                RtlMessageBox.Show(Resources.RowNumber_is_empty,
                            Resources.Input_control,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RowNumber = Convert.ToDecimal(cmbRowNumber.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
