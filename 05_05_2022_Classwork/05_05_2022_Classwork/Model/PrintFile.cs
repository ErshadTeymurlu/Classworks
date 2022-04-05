using _05_05_2022_Classwork.Utilies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_2022_Classwork.Model
{
    class PrintFile<T> where T: IPrintableFile
    {
        public static string Print(T t)
        {
            return t.Print();
        }
    }
}
