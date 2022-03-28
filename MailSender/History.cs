using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MailSender {
    [XmlRoot("history")]
    public class History {
        private static History history;
        private static readonly string file = "history.xml";
        private static readonly int maxCount = 10;

        [XmlElement("subject")]
        public List<string> SubjectsElm;

        private History() {
            SubjectsElm = new List<string>();
        }

        private static History GetInstance() {
            if(history == null) {
                Load();
            }
            return history;
        }

        // タイトルの履歴の末尾に指定した文字列を追加し，最大数を超えた古い履歴を削除する．
        public static void UpdateSubjects(string subject) {
            if(subject != "") {
                Subjects.Add(subject);
            }
            
            if (Subjects.Count > maxCount) {
                Subjects.RemoveRange(maxCount, Subjects.Count - maxCount);
            }
        }

        // タイトルの履歴の最大数を超えた古い履歴を削除する．
        public static void UpdateSubjects() {
            UpdateSubjects("");
        }

        public static IEnumerable<string> GetSubjects() {
            return Subjects;
        }

        public static void Load() {
            if (!File.Exists(file)) {
                history = new History();
                return;
            }

            var serializer = new XmlSerializer(typeof(History));
            using (var reader = new StreamReader(file)) {
                history = (History)serializer.Deserialize(reader);
            }
        }

        public void SaveHistory() {
            var serializer = new XmlSerializer(GetType());
            using (var writer = new StreamWriter(file)) {
                serializer.Serialize(writer, this);
            }
        }

        public static void Save() {
            GetInstance().SaveHistory();
        }

        private static List<string> Subjects {
            get {
                return GetInstance().SubjectsElm;
            }
            set {
                GetInstance().SubjectsElm = value;
            }
        }
    }
}
