using PhotoBook;
using PhotoBookProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBookClass myPhoto = new PhotoBookClass(16);
            Console.WriteLine(myPhoto.GetNumberPages(24));
            BigPhotoBook myBigPhotoBook = new BigPhotoBook(64);
            Console.ReadLine();
        }
    }
}
