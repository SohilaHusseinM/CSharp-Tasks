using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class cstmCmprrCaseInsensetive : IComparer<string>
    {
        public int Compare(string? str1, string? str2)
        {
            return str1?.ToLower().CompareTo(str2?.ToLower()) ?? -1;
        }

    }
}
