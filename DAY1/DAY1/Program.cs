namespace DAY1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size:");
            int n;
            n=int.Parse(Console.ReadLine());
            int[] Arr;
            Console.WriteLine("Enter Array");
            Arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            int mx = -1;
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(Arr[i] == Arr[j]) {
                        mx = Math.Max(mx, j-i-1);
                    }
                }
            }
            Console.WriteLine($"The Max Disatnce = {mx}");
        }
    }
}
