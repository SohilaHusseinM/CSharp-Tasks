namespace Math_Class
{
    public class Cls1
    {
        int p1, p2;
        public Cls1(int a,int b)
        {
            p1 = a;
            p2 = b;
        }
        public int add()
        {
            return p1 + p2;
        }
        public int multiply()
        {
            return p1 * p2;
        }
        public int divide()
        {
            try
            {
                return p1 / p2;
            }
            catch(Exception e) 
            {
                Console.WriteLine("can't devide 0");
                return -1;
            }
        }
        public int subtract()
        {
            return p1 - p2;
        }
    }
}
