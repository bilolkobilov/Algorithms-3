using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes5
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
            }
           
            Student student = new Student("study");
            Teacher teacher = new Teacher("Explain");

            Console.WriteLine();
            Console.WriteLine(teacher.aExplain);
            Console.WriteLine(student.aStudy);
            Console.WriteLine(student.aStudy);          
            Console.ReadLine();          
        }
    }
}
