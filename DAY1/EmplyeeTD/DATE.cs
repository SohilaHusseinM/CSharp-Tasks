using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTypes
{
    public struct HDate
    {
        int day, month, year;
        public HDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        public override string ToString()
        {
            return ($"{day}/{month}/{year}");
        }
    }
}
