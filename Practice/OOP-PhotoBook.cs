using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PhotoBook
    {
        public class PhotoBookk
        {
            private int numPagesss;           

            public PhotoBookk()
            {
                numPagesss = 16;  //default
            }            
            public PhotoBookk(int pages)
            {
                this.numPagesss = pages;  //additional
            }
            public int GetNumberPages()
            {
                return numPagesss;
                
            }
        }

        public class BigPhotoBook: PhotoBookk
        {
            private int numPages;
            public BigPhotoBook()
            {
                numPages = 64;
            }
        }

        //public class PhotoBookTest
        //{
        //    public static void Main()
        //    {
        //        PhotoBookk pb = new PhotoBookk();
        //        Console.WriteLine(pb.GetNumberPages());

        //        PhotoBookk pb1 = new PhotoBookk(24);
        //        Console.WriteLine(pb1.GetNumberPages());

        //        BigPhotoBook bpb = new BigPhotoBook();
        //        Console.WriteLine(bpb.GetNumberPages());
        //    }
        //}
    }
}
