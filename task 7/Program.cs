using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            int fuel = Convert.ToInt32(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }          
            Console.ReadLine();
        }
    }
}
