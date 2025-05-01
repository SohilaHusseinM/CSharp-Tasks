using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class CustomComprer : IEqualityComparer<string>
    {
        public bool Equals(string? str1, string? str2)
        {
            if ((str1?.Length != str2?.Length) || str1 == null || str2 == null)
                return false;

            str1 = new string(str1.OrderBy(c => c).ToArray());
            str2 = new string(str2.OrderBy(c => c).ToArray());

            return str1 == str2;
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return new string(obj.OrderBy(c => c).ToArray()).GetHashCode();
        }
    }
}
