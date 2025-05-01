using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create employees
        Employee emp1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1955, 1, 1), VacationStock = -5 };
        Employee emp2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1990, 1, 1), VacationStock = 10 };
        SalesPerson salesPerson = new SalesPerson { EmployeeID = 3, BirthDate = new DateTime(1995, 1, 1), AchievedTarget = 80 };
        BoardMember boardMember = new BoardMember { EmployeeID = 4, BirthDate = new DateTime(1940, 1, 1) };

        // Create department
        Department department = new Department { DeptID = 1, DeptName = "IT Department" };

        // Add employees to department
        department.AddStaff(emp1);
        department.AddStaff(emp2);
        department.AddStaff(salesPerson);

        // Create club
        Club club = new Club { ClubID = 1, ClubName = "Company Club" };

        // Add employees to club
        club.AddMember(emp1);
        club.AddMember(emp2);
        club.AddMember(boardMember);

        // Perform end-of-year operations
        Console.WriteLine("End-of-year operations...");
        emp1.EndOfYearOperation();
        emp2.EndOfYearOperation();
        salesPerson.EndOfYearOperation(100); // Target is set to 100

        // Test board member resignation
        Console.WriteLine("Board member resigns...");
        boardMember.Resign();

        Console.WriteLine("Testing complete.");
    }
}
