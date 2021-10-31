using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    class CSVData
    {
        List<List<string>> list;

        public CSVData(List<List<string>> list)
        {
            this.list = list;
        }

        public List<string> GetRow(int row)
        {
            if (list.Count <= row)
            {
                return new List<string>();
            }
            return list.ElementAt(row);
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
