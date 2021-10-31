using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MailSender
{
    class MailConfig
    {
        private static MailConfig config;
        private static readonly string file = "config.xml";
        private static readonly string tagRoot = "config";
        private static readonly string tagName = "name";
        private static readonly string tagFrom = "from";
        private static readonly string tagServer = "server";
        private static readonly string tagPort = "port";
        private static readonly string tagUser = "user";
        private static readonly string tagPassword = "password";

        private string name;
        private string from;
        private string server;
        private int port;
        private string user;
        private string password;

        private MailConfig() { }

        private static MailConfig GetInstance()
        {
            if(config == null)
            {
                config = new MailConfig();
                config.LoadConfig();
            }
            return config;
        }

        public void LoadConfig()
        {
            if (!File.Exists(file))
            {
                return;
            }

            var xml = XElement.Load(file);
            XElement? temp;
            name = (temp = xml.Element(tagName)) == null ? "" : temp.Value;
            from = (temp = xml.Element(tagFrom)) == null ? "" : temp.Value;
            server = (temp = xml.Element(tagServer)) == null ? "" : temp.Value;
            user = (temp = xml.Element(tagUser)) == null ? "" : temp.Value;
            password = (temp = xml.Element(tagPassword)) == null ? "" : AESCryption.Decrypt(temp.Value);
            if (!int.TryParse(xml.Element(tagPort).Value, out port))
            {
                port = 587;
            }
        }

        public void SaveConfig()
        {
            using (var sw = new StreamWriter(file))
            {
                sw.Write(string.Format(
                    "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\n" +
                    "<{0}>\n" +
                    "  <{1}>{7}</{1}>\n" +
                    "  <{2}>{8}</{2}>\n" +
                    "  <{3}>{9}</{3}>\n" +
                    "  <{4}>{10}</{4}>\n" +
                    "  <{5}>{11}</{5}>\n" +
                    "  <{6}>{12}</{6}>\n" +
                    "</{0}>\n",
                    tagRoot,
                    tagName,
                    tagFrom,
                    tagServer,
                    tagPort,
                    tagUser,
                    tagPassword,
                    name,
                    from,
                    server,
                    port,
                    user,
                    AESCryption.Encrypt(password)
                ));
            }
        }

        public static void Save()
        {
            GetInstance().SaveConfig();
        }

        public static string Name
        {
            get
            {
                return GetInstance().name;
            }
            set
            {
                GetInstance().name = value;
            }
        }

        public static string From
        {
            get
            {
                return GetInstance().from;
            }
            set
            {
                GetInstance().from = value;
            }
        }

        public static string Server
        {
            get
            {
                return GetInstance().server;
            }
            set
            {
                GetInstance().server = value;
            }
        }

        public static int Port
        {
            get
            {
                return GetInstance().port;
            }
            set
            {
                GetInstance().port = value;
            }
        }

        public static string User
        {
            get
            {
                return GetInstance().user;
            }
            set
            {
                GetInstance().user = value;
            }
        }

        public static string Password
        {
            get
            {
                return GetInstance().password;
            }
            set
            {
                GetInstance().password = value;
            }
        }
    }
}
