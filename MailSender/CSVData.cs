using System.Collections.Generic;
using System.Linq;

namespace MailSender {
    class CSVData
    {
        List<List<string>> list;

        public CSVData(List<List<string>> list)
        {
            this.list = list;
        }

        public IEnumerable<string> GetRow(int row)
        {
            if (list.Count <= row)
            {
                yield break;
            }

            foreach(var e in list.ElementAt(row)) {
                yield return e;
            }
        }

        public IEnumerable<string> GetRowRange(int row, int start, int count) {
            if (list.Count <= row) {
                yield break;
            }

            var l = list.ElementAt(row);
            var range = Enumerable.Range(start, count);
            foreach (var i in range) {
                if(i >= l.Count) {
                    break;
                }
                yield return l.ElementAt(i);
            }
        }

        public IEnumerable<string> GetRowRange(int row, int start) {
            if (list.Count <= row) {
                yield break;
            }

            var l = list.ElementAt(row);
            var range = Enumerable.Range(start, l.Count - start);
            foreach (var i in range) {
                if (i >= l.Count) {
                    break;
                }
                yield return l.ElementAt(i);
            }
        }

        public string GetElement(int row, int col)
        {
            if(list.Count <= row || list.ElementAt(row).Count <= col)
            {
                return "";
            }
            return list.ElementAt(row).ElementAt(col);
        }

        public int RowCount
        {
            get
            {
                return list.Count;
            }
        }

        public int ColCount
        {
            get
            {
                if(list.Count == 0)
                {
                    return 0;
                }
                return list.ElementAt(0).Count;
            }
        }
    }
}
