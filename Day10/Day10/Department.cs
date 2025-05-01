using System;
using System.Collections.Generic;

public class Department
{
    public int DeptID { get; set; }
    public string DeptName { get; set; }
    private List<Employee> Staff = new List<Employee>();

    public void AddStaff(Employee e)
    {
        Staff.Add(e);
        e.EmployeeLayOff += RemoveStaff; // Register for EmployeeLayOff event
    }

    public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
    {
        if (sender is Employee employee && (e.Cause == LayOffCause.VacationStockNegative || e.Cause == LayOffCause.AgeExceeded))
        {
            Staff.Remove(employee);
        }
    }
}
