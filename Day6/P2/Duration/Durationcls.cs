using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duration
{

    internal class Duration
    {
        int Hours, Minutes, Seconds;
        public Duration(int H,int M, int S)
        {
            this.Hours = H;
            this.Minutes = M;
            this.Seconds = S;
        }
        
        public Duration(int seconds)
        {
            this.Hours = seconds / (60 * 60);
            if (this.Hours != 0)
            {
                seconds = seconds % (60 * 60 * this.Hours);
            }
            this.Minutes = seconds / 60;
            if ( this.Minutes != 0)
            {
                seconds = seconds % (60 * this.Minutes);
            }
            
            this.Seconds = seconds;
        }
        public override string ToString()
        {
            if(this.Hours==0)return $"Output: Minutes :{this.Minutes} , Seconds :{this.Seconds}";
            if(this.Hours==0&&this.Minutes==0)return $"Output: Seconds :{this.Seconds}";
            return $"Output: Hours: {this.Hours}, Minutes :{this.Minutes} , Seconds :{this.Seconds}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public override bool Equals(object? obj)
        {
            if(obj is Duration _obj)
            {
                return this.Hours == _obj.Hours && this.Seconds == _obj.Seconds &&
                    this.Minutes == _obj.Minutes;
            }
            throw new Exception("This Object is not Duration Type");
        }
        public static Duration convertToHMS(int duration)
        {
            int Hours = duration / (60 * 60);
            int Minutes = 0, Seconds = 0;
            if (Hours != 0)
                duration = duration % (60 * 60 * Hours);

            Minutes = duration / 60;
            if (Minutes != 0)
                duration = duration % (60 * Minutes);

            Seconds = duration;


            return new Duration(Hours, Minutes, Seconds);

        }
        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration(a.Hours + b.Hours, a.Minutes + b.Minutes,a.Seconds+b.Seconds);
        }
        public static Duration operator +(Duration a, int duration)
        {
            return a + (Duration)convertToHMS(duration);
        }
        public static Duration operator +(int duration, Duration a)
        {
            return a + (Duration)convertToHMS(duration);
        }
        public static Duration operator ++(Duration a) {
            a.Minutes++;
            if (a.Minutes == 60)
            {
                a.Hours++;
                a.Minutes =0;
            }
            return a;
        }
        public static Duration operator --(Duration a)
        {
            if (a.Minutes == 0 && a.Hours == 0)
            {
                a.Seconds = 0;
            }
            else
            {
                a.Minutes--;
                if (a.Minutes < 0)
                {
                    a.Hours--;
                    a.Minutes = 59;
                }
            }
            return a;
        }
        public  static Duration operator -(Duration a)
        {
            return new Duration(-a.Hours, -a.Minutes, -a.Seconds);
        }
        public static bool operator >(Duration a,
                                      Duration b)
        {
            if (a.Seconds == b.Seconds)
            {
                if (a.Minutes == b.Minutes)
                {
                    return a.Hours > b.Hours;
                }
                return a.Minutes > b.Minutes;
            }
            return a.Seconds>b.Seconds;
        }
        public static bool operator <(Duration a,
                                      Duration b)
        {
            if (a.Seconds == b.Seconds)
            {
                if (a.Minutes == b.Minutes)
                {
                    return a.Hours < b.Hours;
                }
                return a.Minutes < b.Minutes;
            }
            return a.Seconds < b.Seconds;
        }
        public static bool operator <=(Duration a,
                                      Duration b)
        {
            if (a.Seconds <= b.Seconds)
            {
                if (a.Minutes <= b.Minutes)
                {
                    return a.Hours <= b.Hours;
                }
                return a.Minutes <= b.Minutes;
            }
            return a.Seconds <= b.Seconds;
        }
        public static bool operator >=(Duration a,
                                      Duration b)
        {
            if (a.Seconds >= b.Seconds)
            {
                if (a.Minutes >= b.Minutes)
                {
                    return a.Hours >= b.Hours;
                }
                return a.Minutes >= b.Minutes;
            }
            return a.Seconds >= b.Seconds;
        }
        public static implicit operator bool(Duration obj)
        {
            if (obj.Seconds == 0 && obj.Minutes == 0 && obj.Seconds == 0) return false;
            return true;
        }
        public static explicit operator DateTime(Duration obj)
        {
            DateTime baseDate = new DateTime(2025, 2, 8);
            return baseDate.AddHours(obj.Hours).AddMinutes(obj.Minutes).AddSeconds(obj.Seconds);
        }


    }
}
