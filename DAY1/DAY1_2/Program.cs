namespace DAY1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string[] strList = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            Array.Reverse(strList);
            s=string.Join(" ", strList);
            Console.WriteLine(s);
        }
    }
}
