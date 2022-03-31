using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_03_2022_Classwork.Models
{
    interface IEngine
    {
        string HorsePower { get; set; }
        int TankSize { get; set; }
        int CurrentOil { get; set; }
        int RemainingOilAmount();
    }
}
