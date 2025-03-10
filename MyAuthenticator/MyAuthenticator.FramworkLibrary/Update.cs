using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyAuthenticator.FramworkLibrary
{
    public class Update
    {
        private static string UpdateUrl = "https://hmovaghari.github.io/root/MyAuthenticator/FramworkApp.Update.txt";
        public static string NoConnection => "NoConnection";
        public static string ItIsUpdate => "It is update";

        public static List<string> IsNeedUpdate(string version)
        {
            try
            {
                using (TimeOutWebClient client = new TimeOutWebClient())
                {
                    var contents = client.DownloadString(UpdateUrl).Split('\n').ToList();
                    if (version != contents[0])
                    {
                        return contents;
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<string>() { NoConnection };
            }
            return new List<string>() { ItIsUpdate };
        }
    }
}
