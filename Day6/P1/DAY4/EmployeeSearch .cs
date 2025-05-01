using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAY4
{
    internal class EmployeeSearch
    {
         int[] NationalIDs; Employee[] Employees;
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeSearch"/> class with the specified employees array.
        /// </summary>
        /// <param name="employees">An array of Employee objects to initialize the EmployeeSearch instance.</param>
        /// <exception cref="ArgumentNullException">Thrown if the employees array is null.</exception>

        public EmployeeSearch(Employee[] employees)
        {
            Employees = employees;
            NationalIDs = new int[employees.Length];

            for (int i = 0; i < employees.Length; i++)
            {
                NationalIDs[i] = employees[i].id;
            }
        }
        /// <summary>
        /// Gets or sets the value at the specified id in the Employees array.
        /// </summary>
        /// <param name="id">The ID of the specific employee.</param>
        /// <returns>The data of the employee if it exists.</returns>
        /// <exception cref="Exception">Thrown when the specified ID does not exist.</exception>

        public Employee this[int id]
        {
            set
            {
                for(int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].id == id)
                    {
                        Employees[i]=value;
                        return;
                    }
                }
                throw new Exception("Invalid id");
            }
            get
            {
                for(int i=0;i< Employees.Length; i++)
                {
                    if (Employees[i].id == id)
                    {
                        return Employees[i];
                    }
                }
                throw new Exception("Invalid id");

            }
        }
        /// <summary>
        /// Gets or sets the value at the specified hiring date of the employee the Employees array.
        /// </summary>
        /// <param name="date">The hiring date of the specific employee.</param>
        /// <returns>The data of the employee if it exists.</returns>
        /// <exception cref="Exception">Thrown when the specified hiring date does not exist.</exception>

        public Employee this[HDate date]
        {
            get
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].Hiring_Date == date)
                    {
                        return Employees[i];
                    }
                }
                throw new Exception("Invalid Hiring date");

            }
            set
            {
                for(int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].Hiring_Date == date)
                    {
                        Employees[i]=value ;
                        return;
                    }
                }
                throw new Exception("Invalid Hiring date");

            }
        }
        /// <summary>
        /// Gets or sets the value at the specified name in the Employees array.
        /// </summary>
        /// <param name="name">The name of the specific employee.</param>
        /// <returns>The data of the employee if it exists.</returns>
        /// <exception cref="Exception">Thrown when the specified name does not exist.</exception>

        public Employee this[string name]
        {
            get
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].Name == name)
                    {
                        return Employees[i];
                    }
                }
                throw new Exception("Invalid name");

            }
            set
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].Name == name)
                    {
                        Employees[i]=value;
                        return;
                    }
                }
                throw new Exception("Invalid name");

            }
        }

       
    }
}
