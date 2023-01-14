using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes7
{
    class Car : IVehiculo
    {
        private int Fuel;      
        public Car(int aFuel)
        {
            Fuel = aFuel;
        }
        public int aFuel
        {
            get
            {
                return Fuel;
            }
            set
            {
                Fuel = value;
            }
        }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not fuel");
            }
        }
        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
}
