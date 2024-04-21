using MyAuthenticator.FramworkApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAuthenticator.FramworkApp
{
    public static class Functions
    {
        public static void SetIcon(this Form form)
        {
            form.Icon = Resources.Favicon;
        }
    }
}
