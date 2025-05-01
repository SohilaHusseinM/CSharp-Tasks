using System;
using System.Collections.Generic;

public class Club
{
    public int ClubID { get; set; }
    public string ClubName { get; set; }
    private List<Employee> Members = new List<Employee>();

    public void AddMember(Employee e)
    {
        Members.Add(e);
        e.EmployeeLayOff += RemoveMember; // Register for EmployeeLayOff event
    }

    public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
    {
        if (sender is Employee employee && e.Cause == LayOffCause.VacationStockNegative)
        {
            Members.Remove(employee);
        }
    }
}
