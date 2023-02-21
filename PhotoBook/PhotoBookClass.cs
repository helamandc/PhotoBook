using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookProject
{
    public class PhotoBookClass
    {
        private int numPages;

        public PhotoBookClass(int defaultPage)
        {
            Console.WriteLine(defaultPage);
        }

        public int GetNumberPages(int page)
        {
            numPages = page;
            return numPages;
        }

    }
}
