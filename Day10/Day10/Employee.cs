using System;

public class Employee
{
    public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

    public int EmployeeID { get; set; }
    public DateTime BirthDate { get; set; }
    public int VacationStock { get; set; }

    public bool RequestVacation(DateTime from, DateTime to)
    {
        // Example logic: deduct vacation days and approve if stock is sufficient
        int requestedDays = (to - from).Days;
        if (VacationStock >= requestedDays)
        {
            VacationStock -= requestedDays;
            return true;
        }
        return false;
    }

    public void EndOfYearOperation()
    {
        // Check conditions for layoff
        if (VacationStock < 0)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
        }
        else if (DateTime.Now.Year - BirthDate.Year > 60)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeExceeded });
        }
    }

    protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
    {
        EmployeeLayOff?.Invoke(this, e);
    }
}

public enum LayOffCause
{
    VacationStockNegative,
    AgeExceeded
}

public class EmployeeLayOffEventArgs : EventArgs
{
    public LayOffCause Cause { get; set; }
}
