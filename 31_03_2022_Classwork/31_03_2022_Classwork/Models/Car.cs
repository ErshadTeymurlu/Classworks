using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_03_2022_Classwork.Models
{
    class Car : Vehicle, IWheel, ITransmission, IEngine
    {
        private string _doorCount;
        private string _winCode;
        public string WheelThickness { get; set; }
        public string TransmissionType { get; set; }
        public string HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public Car(string doorCount, string wincCode, int driveTime, int drivePath, string wheelThickness, string transmissionType, string horsePower, int tankSize, int currentOil)
        {
            DoorCount = doorCount;
            WinCode = wincCode;
            DriveTime = driveTime;
            DrivePath = drivePath;
            WheelThickness = wheelThickness;
            TransmissionType = transmissionType;
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
        }
        public string DoorCount
        {
            get { return _doorCount; }
            set
            {
                _doorCount = value;
            }
        }
        public string WinCode
        {
            get { return _winCode; }
            set
            {
                _winCode = value;
            }
        }

        public override int AverageSpeed()
        {
            return DrivePath / DrivePath;
        }

        public int RemainingOilAmount()
        {
            return TankSize - CurrentOil; 
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
