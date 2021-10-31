using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace MailSender
{
    class CSVReader
    {
        public CSVData ReadCSV(string path)
        {
            var list = new List<List<string>>();
            using (var parser = new TextFieldParser(path))
            {
                // カンマ区切りの指定
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // フィールドが引用符で囲まれているか
                parser.HasFieldsEnclosedInQuotes = false;
                // フィールドの空白トリム設定
                parser.TrimWhiteSpace = true;

                // ファイルの終端までループ
                while (!parser.EndOfData)
                {
                    // フィールドを読込
                    var row = parser.ReadFields();
                    list.Add(row.ToList());
                }
            }
            return new CSVData(list);
        }
    }
}
