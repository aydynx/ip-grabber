using System.Net;
using System.Collections.Specialized;

namespace webhookNotifier
{
    static class Notify
    {
        public static void Main()
        {
            string webhook = "YOUR WEBHOOK HERE";

            var wc = new WebClient();
            NameValueCollection content = new NameValueCollection();

            string ip = wc.DownloadString("https://ip.aydyn.workers.dev/");

            content.Add("content", ip);
            wc.UploadValues(webhook, content);
        }
    }
}