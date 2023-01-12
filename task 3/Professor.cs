using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes3
{
     class Professor : Person
     {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }     
        public override  void SetAge()
        {
            Console.WriteLine(25);
        }
     }
}
