using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework4_classes5
{
     class Teacher 
     {
        private string Explain;
        public Teacher(string aExplain)
        {
            Explain = aExplain;

        }
        public string aExplain
        {
            get
            {
                return Explain;
            }
            set
            {
                Explain = value;
            }
        }
     }
}
