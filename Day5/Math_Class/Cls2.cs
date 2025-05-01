using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Class
{
    public static class Cls2
    {
       
        public static int add(int p1,int p2)
        {
            return p1 + p2;
        }
        public static int multiply(int p1, int p2)
        {
            return p1 * p2;
        }
        public static int divide(int p1, int p2)
        {
            try
            {
                return p1 / p2;
            }
            catch (Exception e)
            {
                Console.WriteLine("can't devide 0");
                return -1;
            }
        }
        public static int subtract(int p1, int p2)
        {
            return p1 - p2;
        }
    }
}
