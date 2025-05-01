using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day09;


namespace Day09
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList
       ,DEl3 fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        
    }
}
