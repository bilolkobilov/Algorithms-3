using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes1
{
     class Program
    {
        static void Main(string[] args)
        {
        
            Person[] persons = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Name: ");
                string name = Convert.ToString(Console.ReadLine());
                persons[i] = new Person(name);
                
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            Console.ReadLine();
        }
    }
}