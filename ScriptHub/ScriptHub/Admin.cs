using System;
using System.Net;
using System.Windows.Forms;

namespace ScriptHub
{
    class Admin
    {
        public static void dopeadmin()
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("https://coders2342.000webhostapp.com/admin/dopeadmin");
            Clipboard.SetText(htmlCode);
        }

        public static void Elysian()
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("https://coders2342.000webhostapp.com/admin/Elysian%20Admin%20Commands");
            Clipboard.SetText(htmlCode);
        }

        public static void Fedora()
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("https://coders2342.000webhostapp.com/admin/Fedora%20Admin");
            Clipboard.SetText(htmlCode);
        }

        public static void Pickles1()
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("https://coders2342.000webhostapp.com/admin/Pickles%20Hook");
            Clipboard.SetText(htmlCode);
        }

        public static void PicklesS()
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("https://coders2342.000webhostapp.com/admin/Pickles%20Script");
            Clipboard.SetText(htmlCode);
        }

        public static void Pickles2()
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("https://coders2342.000webhostapp.com/admin/Pickles%20Script%202");
            Clipboard.SetText(htmlCode);
        }

        public static void Plasma()
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("https://coders2342.000webhostapp.com/admin/Plasma%20v3%20Premium");
            Clipboard.SetText(htmlCode);
        }

        public static void Rocky()
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("https://coders2342.000webhostapp.com/admin/Rocky%202U%20Admin");
            Clipboard.SetText(htmlCode);
        }
    }
}
