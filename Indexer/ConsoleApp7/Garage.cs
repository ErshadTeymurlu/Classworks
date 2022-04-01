using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Garage
    {
        private Car[] cars;
        public Garage(int size)
        {
            cars = new Car[size];
        }
        public Car this[int index]
        {
            get
            {
                return cars[index];
            }
            set
            {
                cars[index] = value;
            }
        }
    }
}
