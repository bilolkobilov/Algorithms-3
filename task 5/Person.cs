using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework4_classes5
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
    }
}
