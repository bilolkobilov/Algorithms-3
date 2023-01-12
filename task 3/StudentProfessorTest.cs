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
            student.SetAge();
            student.Greet();
            student.ShowAge();
            student.Study();

            Professor professor = new Professor();
            professor.SetAge();
            professor.Greet();
            professor.Explain();

            Console.ReadLine();
        }
    }
}
