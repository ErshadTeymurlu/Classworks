using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_05_2022_Classwork.Utilies;


namespace _05_05_2022_Classwork.Model
{
    class Pdf : IPrintableFile
    {
        private string _pageCount;
        private string _fileName;
        public string PageCount { get { return _pageCount; }
            set 
            {
                _pageCount = value;
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
        public Pdf(string pageCount, string fileName)
        {
            PageCount = pageCount;
            FileName = fileName;
        }

        public string Print()
        {
            return $"File Name - {FileName}, Page Count - {PageCount} printed!";
        }
    }
}
