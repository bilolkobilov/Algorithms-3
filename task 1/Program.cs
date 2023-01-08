using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static homework4_classes.Person;

namespace homework4_classes
{
     class Program
    {
        static void Main(string[] args)
        {
            Person[] Person1 = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Name: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Name: ");
                string name1 = Convert.ToString(Console.ReadLine());
                Console.Write("Name: ");
                string name2 = Convert.ToString(Console.ReadLine());


                Person1[i] = new Person(name,name1,name2);

              
                
            }
            Console.WriteLine(Person1[0]);
            Console.ReadLine();
        }
    }
}
