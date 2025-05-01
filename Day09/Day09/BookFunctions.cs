using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string str = "";
            foreach (string x in B.Authors) str += x + '&';
            return str;
        }
        public static string GetPrice(Book B)
        {
            return Convert.ToString(B.Price);
        }
    }

}
