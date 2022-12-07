using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer
{
    public class BmwCar
    {
        public bool XDrive { get; set; }
        public string Model { get; set; }
        public int Fuel { get; set; }

        public BmwCar(bool isXdrive, string model, int fuel)
        {
            XDrive = isXdrive;
            Model = model;
            Fuel = fuel;
        }

        void Drive()
        {

        }

        void Refuel(int howMuch)
        {
            Fuel += howMuch;
        }
    }
}
