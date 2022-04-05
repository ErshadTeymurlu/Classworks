using _05_05_2022_Classwork.Utilies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_2022_Classwork.Model
{
    class Excel : IPrintableFile
    {
        private string _columnCount;
        private string _rowCount;
        private string _fileName;
        public string ColumnCount { get { return _columnCount; }
            set
            {
                _columnCount = value;
            }
        }
        public string RowCount
        {
            get { return _rowCount; }
            set
            {
                _rowCount = value;
            }
        }
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
            }
        }
        public Excel(string columnCount, string rowCount, string fileName)
        {
            ColumnCount = columnCount;
            RowCount = rowCount;
            FileName = fileName;
        }

        public string Print()
        {
            return $"File Name - {FileName}, Column Count - {ColumnCount}, Row Count - {RowCount} printed!";
        }

    }
}
