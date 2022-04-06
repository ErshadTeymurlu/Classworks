using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_04_2022_Classwork.Utilies
{
    class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        { }
    }
}
