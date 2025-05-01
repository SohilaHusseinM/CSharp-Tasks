using System.Reflection;
using DTypes;

namespace DAY4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of Employee");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                n = 0;
                Console.WriteLine(e.Message);
            }

            Employee[] EmpArr;
            int[] nationalId;
            nationalId = new int[n];
            EmpArr = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                EmpArr[i] = new Employee();
                Console.WriteLine($"Enter the data for Employee number{i + 1}");

                Console.WriteLine("Name: ");
                String name = Console.ReadLine();
                EmpArr[i].Name = name;

                int national;
                do
                {
                    Console.Write("National ID: ");

                } while (int.TryParse(Console.ReadLine(), out national) == false);
                nationalId[i] = national;
                EmpArr[i].id = nationalId[i];


                Gender gen;
                do
                {
                    Console.Write("Enter your Gender(M/F) : ");
                }
                while (!Enum.TryParse(Console.ReadLine(), true, out gen) || (gen != Gender.M && gen != Gender.F));

                EmpArr[i].Gender = gen;


                Console.Write("\nHiring Date:\n");
                int a, b, c;
                do
                {
                    Console.Write("            day: ");

                }
                while (!int.TryParse(Console.ReadLine(), out a) || (a<1 ||a>31));

                do
                {
                    Console.Write("            month: ");

                }
                while (!int.TryParse(Console.ReadLine(), out b)|| (b<1 || b>12));

                do
                {
                    Console.Write("            year: ");

                }
                while (!int.TryParse(Console.ReadLine(), out c) || (c<1940));

                HDate hiringdate = new HDate(a, b, c);
                EmpArr[i].Hiring_Date=(hiringdate);

                double sal;
                do
                {
                    Console.Write("\nSalary: ");

                } while (!double.TryParse(Console.ReadLine(), out sal));

                EmpArr[i].salary = sal;


                int num;
                do
                {
                    Console.WriteLine("\nEnter the number of privileges the employee has (number >= 1 and <= 4): ");
                } while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 4);

                
                SecurityLevel privileges = 0;
                int k = 0;
                Console.Write("Enter a privilege (secretary/developer/DBA/guest): \n");
                while (k<num)
                {
                    SecurityLevel priv;
                    do
                    {
                        Console.Write($"{k+1}: ");
                    } while (!Enum.TryParse(Console.ReadLine(), true, out priv));
                    
                        privileges |= priv;
                    k++;
                }
                EmpArr[i].Security = privileges;


                Console.WriteLine("-------------------------");

            }

            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine(EmpArr[i]);
            }*/
            /*
            //search emplyee id=11



            EmployeeSearch empS = new EmployeeSearch(EmpArr);
        
            if (empS[11].id == -1)
            {
                Console.WriteLine("Not found");
            }
            else Console.WriteLine(empS[11]);

            //search employee name=mohamed
            if (empS["mohamed"].id == -1)
            {
                Console.WriteLine("Not found");
            }
            else Console.WriteLine(empS["mohamed"]);


            //search employee hdate='1/2/2000'
            if (empS[new HDate(1, 1, 2000)].id == -1)
            {
                Console.WriteLine("Not found");
            }
            else Console.WriteLine(empS[new HDate(1, 1, 2000)]); 

            */

            Array.Sort(EmpArr);
            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine($"Boxing: {Employee.boxing}\n");
        }
    }
}
