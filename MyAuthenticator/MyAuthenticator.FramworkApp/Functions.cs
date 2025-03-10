using MyAuthenticator.FramworkApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAuthenticator.FramworkData.Context;
using MyAuthenticator.FramworkData.Repository;
using System.Drawing;

namespace MyAuthenticator.FramworkApp
{
    public static class Functions
    {
        public static Language Language { get; private set; }

        public static string Colon => " :";

        public static void SetIcon(this Form form)
        {
            form.Icon = Resources.Favicon1;
        }

        public static void LoadLanuage()
        {
            Language = SettingRepository.GetLanguage();
        }

        public static bool IsEnglish()
        {
            return Language.Name() == Language.English.Name();
        }

        public static void ChangeDirection(Panel panel, RightToLeft rightToLeft)
        {
            if (rightToLeft == RightToLeft.No)
            {
                int panelWidth = panel.Width;

                foreach (Control ctrl in panel.Controls)
                {
                    int controlDistanceFromRight = panelWidth - (ctrl.Location.X + ctrl.Width);
                    ctrl.Location = new Point(controlDistanceFromRight, ctrl.Location.Y);

                    if (ctrl.Anchor == (AnchorStyles.Top | AnchorStyles.Right))
                    {
                        ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    }
                    else if (ctrl.Anchor == (AnchorStyles.Top | AnchorStyles.Left))
                    {
                        ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    }

                    ctrl.RightToLeft = rightToLeft;
                }
            }
            else
            {

            }
        }
    }
}
