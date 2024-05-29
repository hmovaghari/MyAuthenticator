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

        public static List<string> IsNeedUpdate(string version)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    var contents = client.DownloadString(UpdateUrl).Split('\n').ToList();
                    if (version != contents[0])
                    {
                        return contents;
                    }
                }
            }
            catch (Exception ex) { }
            return null;
        }
    }
}
