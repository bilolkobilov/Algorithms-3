using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Enter a Name ");
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
        
            dog.Eat();
            Console.ReadLine();
        }
    }
}
