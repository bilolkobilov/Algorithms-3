using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework4_classes
{
    class Person
    {
        private string name;
        private string name1;
        private string name2;

        public Person(string aname, string aname1, string aname2)
        {
            name = aname;
            name1 = aname1;
            name2 = aname2;
        }

        public string aname
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string aname1
        {
            get
            {
                return name1;
            }
            set
            {
                name1 = value;
            }
        }
        public string aname2
        {
            get
            {
                return name2;
            }
            set
            {
                name2 = value;
            }
        }

        public override string ToString()
        {
            return "Hello! My Name is "+  name + "\n"+ "Hello! My Name is " + name1 + "\n"+ "Hello! My Name is " + name2;
        }
    }    
}
