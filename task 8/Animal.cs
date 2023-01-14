using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes8
{
    public abstract class Animal
    {
        private string Name;
        public void SetName(string aName)
        {
            Name = aName;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
}
