using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DTypes
{
    public struct HDate:IComparable
    {
        int day, month, year;
        public HDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        /// <summary>
        /// Converts the Hiring date's data into a readable string representation.
        /// </summary>
        /// <returns>A string that contains the Hiring date day / month / year<returns> 
        public override string ToString()
        {
            return ($"{day}/{month}/{year}");
        }
        /// <summary>
        /// Determines whether two <see cref="HDate"/> instances represent the same date.
        /// </summary>
        /// <param name="left">The first <see cref="HDate"/> instance to compare.</param>
        /// <param name="right">The second <see cref="HDate"/> instance to compare.</param>
        /// <returns>
        /// <c>true</c> if the day, month, and year of both instances are equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator ==(HDate left, HDate right)
        {
            if(left.day==right.day &&left.month==right.month &&left.year==right.year) 
                { return true;
                }
            return false;
        }
        /// <summary>
        /// Determines whether two <see cref="HDate"/> instances do not represent the same date.
        /// </summary>
        /// <param name="left">The first <see cref="HDate"/> instance to compare.</param>
        /// <param name="right">The second <see cref="HDate"/> instance to compare.</param>
        /// <returns>
        /// <c>true</c> if the day, month, or year of the two instances are not equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator !=(HDate left, HDate right)
        {
            if (left.day == right.day && left.month == right.month && left.year == right.year)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Compares the current <see cref="HDate"/> instance with another object of type <see cref="HDate"/>.
        /// </summary>
        /// <param name="obj">The object to compare, expected to be of type <see cref="HDate"/>.</param>
        /// <returns>
        /// A value less than zero if the current <see cref="HDate"/> is earlier than the other; 
        /// zero if the two dates are equal; a value greater than zero if the current date is later than the other.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown if the provided object is not of type <see cref="HDate"/>.</exception>
        public int CompareTo(object? obj)
        {
            if (obj is HDate other)
            {
                if (year != other.year)
                    return year.CompareTo(other.year);
                if (month != other.month)
                    return month.CompareTo(other.month);
                return day.CompareTo(other.day);
            }
            throw new ArgumentException("This object is not date");
        }

      
    }
}
