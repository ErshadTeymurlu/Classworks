using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_2022_Classwork.Utilies
{
    interface IPrintableFile
    {
        string FileName { get; set; }
        string Print();
    }
}
