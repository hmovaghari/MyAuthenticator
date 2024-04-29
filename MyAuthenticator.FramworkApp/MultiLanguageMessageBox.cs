using MyAuthenticator.FramworkData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAuthenticator.FramworkApp
{
    public class MultiLanguageMessageBox
    {
        public static DialogResult Show(string text)
        {
            return Functions.IsEnglish() ? MessageBox.Show(text) : RtlMessageBox.Show(text);
        }

        public static DialogResult Show(string text, string caption)
        {
            return Functions.IsEnglish() ? MessageBox.Show(text, caption) : RtlMessageBox.Show(text, caption);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return Functions.IsEnglish() ? MessageBox.Show(text, caption, buttons) : RtlMessageBox.Show(text, caption, buttons);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return Functions.IsEnglish() ? MessageBox.Show(text, caption, buttons, icon) : RtlMessageBox.Show(text, caption, buttons, icon);
        }

        //public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
        //{
        //    return IsEnglish() ? MessageBox.Show(text, caption, buttons, icon, options) : RtlMessageBox.Show(text, caption, buttons, icon, options);
        //}

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return Functions.IsEnglish() ? MessageBox.Show(text, caption, buttons, icon, defaultButton) : RtlMessageBox.Show(text, caption, buttons, icon, defaultButton);
        }
    }
}
