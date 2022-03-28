using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    class Weapon
    {
        private int _bulletCapacity;
        private int _bulletAmount;
        private int _dischargeSecond;
        private bool _fireMode;
        public bool FireMode
        {
            get { return _fireMode; }
            set
            {
                _fireMode = value;
            }
        }
        public int BulletCapacity
        {
            get { return _bulletCapacity; }
            set
            {
                if (value > 0 && value <= 300) _bulletCapacity = value;
            }
        }
        public int BulletAmount
        {
            get { return _bulletAmount; }
            set
            {
                if (value <= BulletCapacity && value >= 0) _bulletAmount = value;
            }
        }
        public int DischargeSecond
        {
            get { return _dischargeSecond; }
            set
            {
                if (value > 0) _dischargeSecond = value;
            }
        }
        public Weapon(int bulletCapacity, int bulletAmount, int dischargeSecond, char fireMode)
        {
            BulletCapacity = bulletCapacity;
            BulletAmount = bulletAmount;
            DischargeSecond = dischargeSecond;

            if(fireMode == 'S' || fireMode == 's') _fireMode = true;
            if(fireMode == 'A' || fireMode == 'a') _fireMode = false;
        }
        public void ChangeFireMode()
        {
            if (_fireMode == true)
            {
                _fireMode = false;
                return;
            }
            if (_fireMode == false) _fireMode = true;
        }
        public void Shot()
        {
            if (_fireMode == true)
            {
                BulletAmount--;
                return;
            }
            else BulletAmount -= 3;
        }
        public double Fire()
        {
            double dischargeSecond = (double)(DischargeSecond * BulletAmount) / (double)BulletCapacity;
            BulletAmount = 0;
            return dischargeSecond;
        }
        public int GetBulletInfo()
        {
            return BulletAmount;
        }
        public void Reload()
        {
            if(BulletAmount!=BulletCapacity) BulletAmount = BulletCapacity;
        }
    }
}
