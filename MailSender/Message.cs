using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    static class Message
    {
        public static readonly string AreYouSureToSendEmail = "メールを送信しますか？";
        public static readonly string Complete = "完了";
        public static readonly string CSVFileIsInvalid = "CSVファイルが不正です．";
        public static readonly string FailedToSendEmailToV0 = "メール送信に失敗(to {0})";
        public static readonly string MailSending0SlashV0 = "メール送信中...(0/{0})";
        public static readonly string MailSendingV0SlashV1 = "メール送信中...({0}/{1})";
        public static readonly string PleaseSpecifyCSVFile = "CSVファイルを指定してください．";
        public static readonly string PleaseSpecifyTemplateFile = "テンプレートファイルを指定してください．";
        public static readonly string PortNumberIsInvalid = "ポート番号が不正です．";
        public static readonly string SentEmailToV0 = "メールを送信しました(to {0})";
        public static readonly string SubjectIsNotInput = "タイトルが入力されていません．";
        public static readonly string V0DoesNotExist = "{0}が存在しません．";

        // ロガー用
        public static readonly string V0InfoV1 = "{0}  Info: {1}";
        public static readonly string V0ErrorV1 = "{0} Error: {1}";
    }
}
