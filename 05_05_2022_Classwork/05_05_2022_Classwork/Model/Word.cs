using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_05_2022_Classwork.Utilies;


namespace _05_05_2022_Classwork.Model
{
    class Word : IPrintableFile
    {
        private string _wordCount;
        private string _fileName;
        public string WordCount
        {
            get { return _wordCount; }
            set
            {
                _wordCount = value;
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
        public Word(string wordCount, string fileName)
        {
            WordCount = wordCount;
            FileName = fileName;
        }

        public string Print()
        {
            return $"File Name - {FileName}, Word Count - {WordCount} printed!";
        }
    }
}
