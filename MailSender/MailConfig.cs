using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MailSender {
    [XmlRoot("config")]
    public class MailConfig {
        private static MailConfig config;
        private static readonly string file = "config.xml";

        [XmlElement("name")]
        public string NameElm;

        [XmlElement("from")]
        public string FromElm;

        [XmlElement("server")]
        public string ServerElm;

        [XmlElement("port")]
        public int PortElm;

        [XmlElement("user")]
        public string UserElm;

        [XmlElement("password")]
        public string CryptedPassword;

        private string password;

        public class Domains {
            private static Domains domains;

            [XmlAttribute("check")]
            public bool Check;

            [XmlElement("value")]
            public List<string> Values;

            private Domains() {}

            public static Domains GetInstance() {
                if(domains == null) {
                    domains = new Domains();
                }
                return domains;
            }
        }

        [XmlElement("domains")]
        public Domains DomainListElm;

        private MailConfig() { }

        private static MailConfig GetInstance()
        {
            if(config == null)
            {
                Load();
            }
            if(config.DomainListElm == null) {
                config.DomainListElm = Domains.GetInstance();
            }
            return config;
        }

        public static void Load()
        {
            if (!File.Exists(file)) {
                config = new MailConfig();
                config.PortElm = 587;
                return;
            }

            var serializer = new XmlSerializer(typeof(MailConfig));
            using (var reader = new StreamReader(file)) {
                config = (MailConfig)serializer.Deserialize(reader);
            }

            if(config.CryptedPassword == null) {
                return;
            }

            config.password = AESCryption.Decrypt(config.CryptedPassword);
        }

        public void SaveConfig()
        {
            CryptedPassword = AESCryption.Encrypt(password);

            var serializer = new XmlSerializer(GetType());
            using (var writer = new StreamWriter(file)) {
                serializer.Serialize(writer, this);
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
                return GetInstance().NameElm;
            }
            set
            {
                GetInstance().NameElm = value;
            }
        }

        public static string From
        {
            get
            {
                return GetInstance().FromElm;
            }
            set
            {
                GetInstance().FromElm = value;
            }
        }

        public static string Server
        {
            get
            {
                return GetInstance().ServerElm;
            }
            set
            {
                GetInstance().ServerElm = value;
            }
        }

        public static int Port
        {
            get
            {
                return GetInstance().PortElm;
            }
            set
            {
                GetInstance().PortElm = value;
            }
        }

        public static string User
        {
            get
            {
                return GetInstance().UserElm;
            }
            set
            {
                GetInstance().UserElm = value;
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

        public static bool DomainCheck {
            get {
                return GetInstance().DomainListElm.Check;
            }
            set {
                GetInstance().DomainListElm.Check = value;
            }
        }

        public static List<string> DomainList {
            get {
                return GetInstance().DomainListElm.Values ?? new List<string>();
            }
            set {
                GetInstance().DomainListElm.Values = value;
            }
        }
    }
}
