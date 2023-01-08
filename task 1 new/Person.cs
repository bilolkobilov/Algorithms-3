using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework4_classes1
{
     class Person
     {
        private string Name;
        public Person(string aName)
        {
            Name = aName;
        }
        public string aName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

     }
}