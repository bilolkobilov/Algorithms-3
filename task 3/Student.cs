using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace homework4_classes3
{
      class Student : Person
      {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is 19 years old");
        }
      }
}
