namespace Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Duration instances
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            // Output: Hours: 1, Minutes :10 , Seconds :15

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            // Output: Hours: 1, Minutes :0 , Seconds :0

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            // Output: Hours: 2, Minutes :10 , Seconds :0

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            // Output: Minutes :11 , Seconds :6

            // Testing operator overloading
            D3 = D1 + D2;
            Console.WriteLine($"D3 (D1 + D2): {D3}\n");

            D3 = D1 + 7800;
            Console.WriteLine($"D3 (D1 + 7800 seconds): {D3}\n");

            D3 = 666 + D3;
            Console.WriteLine($"D3 (666 seconds + D3): {D3}\n");

            D3 = D1++;
            Console.WriteLine($"D3 (D1++): {D3}");
            Console.WriteLine($"D1 after increment: {D1}\n");

            D3 = --D2;
            Console.WriteLine($"D3 (--D2): {D3}\n");

            D1 = -D2;
            Console.WriteLine($"D1 (-D2): {D1}\n");

            // Testing comparison operators
            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }
            else if (D1 <= D2)
            {
                Console.WriteLine("D1 is less than or equal to D2");
            }

            // Testing implicit conversion to bool
            if (D1)
            {
                Console.WriteLine("D1 is true");
            }
            else
            {
                Console.WriteLine("D1 is false");
            }

            // Explicit casting to DateTime
            DateTime Obj = (DateTime)D1;
            Console.WriteLine($"DateTime from D1: {Obj}");
        }
    }
}
