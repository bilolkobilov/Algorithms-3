using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes3
{
    class StudentProfessorTest
    {
        public static void Main()
        {
            Person person = new Person();
            person.Greet();
                       
            Student student = new Student();
            student.SetAge(19);
            student.Greet();
            student.ShowAge();
            student.Study();

            Professor professor = new Professor();
            professor.SetAge(25);
            professor.ShowAge();
            professor.Greet();
            professor.Explain();

            Console.ReadLine();
        }
    }
}
