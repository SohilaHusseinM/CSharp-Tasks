using System.Security.Cryptography;
using DTypes;
using EmplyeeTD;
namespace DAY2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Employee[] EmpArr;
            EmpArr = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the data for Employee number{i + 1}");
                Console.Write("Id: ");
                EmpArr[i].setId(int.Parse(Console.ReadLine()));

                Console.Write("\nGender(M/F) ");
                EmpArr[i].setGender(Console.ReadLine());

                Console.Write("\nHiring Date:\n            day: ");
                int a, b, c;
                a = int.Parse(Console.ReadLine());
                Console.Write("            month: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("            year: ");
                c = int.Parse(Console.ReadLine());
                HDate hiringdate = new HDate(a, b, c);
                EmpArr[i].sethiringDate(hiringdate);

                Console.Write("\nSalary ");
                string inp = Console.ReadLine();
                double.TryParse(inp, out double sal);
                EmpArr[i].setSalary(sal);
                Console.WriteLine();

            }
            EmpArr[0].setSecurity("DBA");
            EmpArr[1].setSecurity("Guest");
            EmpArr[^1].setSecurity("guest");
            EmpArr[^1].setSecurity("Developer");
            EmpArr[^1].setSecurity("secretary");
            EmpArr[^1].setSecurity("DBA");
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(EmpArr[i]);
            }

        }
    }
}
