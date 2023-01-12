using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes4
{
    class PhotoBook
    {
        protected int numPages;
       
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook( int numPages1)
        {
            numPages = 24;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
