using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using BLL.EntityLists;
using DAL;

namespace BLL.EntityManagers
{
    public static class EmployeeManager
    {
        static DataBaseM manager = new();

        public static EmployeeList SelectAllEmployees()
        {
            DataTable dt=new();
            try
            {
                return DataTableToEmployeeList(manager.ExecuteDataTable("SelectAllEmployees"));
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"Error Ocurred while executing stored procedure (selectAllEmployee) ex.message{ex.Message}");
            }
            return DataTableToEmployeeList(dt);
        }
        public static bool UpdateEmpLvl(string empId, int job_lvl)
        {
            bool checkUpdates = false;
            try
            {
                Dictionary<string, object> new_dictionaty = new()
                {
                    ["emp_id"] = empId,
                    ["job_lvl"] = job_lvl
                };
                checkUpdates= manager.ExecuteNonQuery("UpdateEmpLvl", new_dictionaty) > 0; ;

            }
            catch(Exception ex)
            {
                Trace.WriteLine($"Error Ocurred while executing stored procedure (UpdateEmpLvl) ex.message{ex.Message}");

            }
            return checkUpdates;

        }
        #region Mapping Function
        internal static EmployeeList DataTableToEmployeeList(DataTable Dt)
        {
            EmployeeList employees = new EmployeeList();
            try
            {
                /*foreach(DataRow dr in Dt?.Rows) it Dt it null will throw exception
                {
                    employees.Add(DataRowToEmployee(dr));
                }*/

                for(int i = 0; i < Dt?.Rows?.Count; i++)//more safety
                {
                    employees.Add(DataRowToEmployee(Dt.Rows[i]));
                }
                return employees;
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"Error ocurred while Fitching data ex.message{ex.Message}");
            }
            return new();
           // return employees;
        }
        internal static Employee DataRowToEmployee(DataRow Dr)
        {
            Employee emp = new Employee(){fname = "NA", lname="NA", job_id=0, pub_id="NA", hire_date=new DateTime() };
            try
            {
                //emp.emp_id = Convert.ToInt16(Dr["emp_id"]); 
                // all this attrebutes doesn't allow null
                emp.fname = Dr.Field<string>("fname");
                emp.lname = Dr.Field<string>("lname");
                emp.emp_id = Dr.Field<string>("emp_id");//field extentions method thorw error if the data is null
                emp.job_id = Dr.Field<short>("job_id");
                emp.pub_id = Dr.Field<string>("pub_id");
                emp.hire_date = Dr.Field<DateTime>("hire_date");

                //attributes allow null
                if (int.TryParse(Dr["job_lvl"]?.ToString()??"-1",out int Tempint))
                {
                    emp.job_lvl = Tempint;
                }
                if (!string.IsNullOrEmpty(Dr["minit"]?.ToString()) && char.TryParse(Dr["minit"].ToString(), out char Tempchar))
                {
                    emp.minit = Tempchar;
                }
                else
                {
                    emp.minit = null; // Or any default handling for null
                }
               
            }                                        
            catch(Exception ex)
            {
                Trace.WriteLine($"Error ocurred while Fitching data ex.message{ex.Message}");
            }
            return emp;
        }
        #endregion
    }
}
