using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_classes4
{
    class PhotoBookTest
    {
        public static void Main()
        {
            PhotoBook photoBook = new PhotoBook();
            photoBook.GetNumberPages();

            PhotoBook photoBook1 = new PhotoBook(24);
            photoBook1.GetNumberPages();

            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            bigPhotoBook.GetNumberPages();

            Console.WriteLine(photoBook.GetNumberPages());
            Console.WriteLine(photoBook1.GetNumberPages());
            Console.WriteLine(bigPhotoBook.GetNumberPages());
            Console.ReadLine();
        }
    }
}
