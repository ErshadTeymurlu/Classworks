using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_03_2022_Classwork.Models
{
    abstract class Vehicle
    {
        private int _driveTime;
        private int _drivePath;
        public int DriveTime { get { return _driveTime; } 
            set 
            {
                if(DriveTime>0) _driveTime = value; 
            }
        }
        public int DrivePath
        {
            get { return _drivePath; }
            set
            {
                if (DrivePath > 0) _drivePath = value;
            }
        }
        public abstract int AverageSpeed();
        public abstract void ShowInfo();
    }
}
