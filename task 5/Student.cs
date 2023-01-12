using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework4_classes5
{
     class Student 
    {
        private string Study;
        public Student(string aStudy)
        {
            Study = aStudy;
          
        }
        public string aStudy
        {
            get
            {
                return Study;
            }
            set
            {
                Study = value;
            }
        }
     }
}
