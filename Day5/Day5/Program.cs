using _3D_point;
namespace Points
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 2, 3);
            Console.WriteLine(p);

            #region d5
            /* Point p1 = new(0, 0, 0);
             try
             {
                 p1.Xpos = int.Parse(Console.ReadLine());
             } catch (Exception m)
             {
                 Console.WriteLine(m.Message);
             }
             //tryParse
             int y;
             if (int.TryParse(Console.ReadLine(), out y)) 
             {
                 p1.Ypos = y;
             }
             //convert
             try
             {
                 p1.Zpos = Convert.ToInt32(Console.ReadLine());
             }
             catch (Exception m)
             {
                 Console.WriteLine(m.Message);
             }

             Point p2 = new Point(int.Parse(Console.ReadLine()), 
                 int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

             Console.WriteLine($"Point1: {p1}\nPoint2: {p2}");

             */
            /*  //equals function
              Point p3 = new Point(1, 2, 3);
              Point p4 = new Point(1, 2, 3);


              if (p3.Equals(p4))
              {
                  Console.WriteLine("p3 = p4");
              }
              else Console.WriteLine("p3!=p4");
              */
            #endregion

            String implicit_casting = p;
            Console.WriteLine($"Point to string {implicit_casting}");


            Console.WriteLine("--------------------");
            Point[] arr = new Point[]
            {
                new Point(9,2,3),
                new Point(5,8,4),
                new Point(5,3,9),
                new Point(8,9,10)
            };
            Array.Sort(arr);
            foreach (var point in arr)
            {
                Console.WriteLine(point);
            }
            Console.WriteLine("----------------------");
            Point p1 = new Point(3, 4, 7);
            Point p2 = (Point)p1.Clone();
            Console.WriteLine("Are p1 and p2 the same instance?");
            if (object.ReferenceEquals(p1, p2))
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        }
    }
}
