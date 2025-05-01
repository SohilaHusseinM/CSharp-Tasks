public class SalesPerson : Employee
{
    public int AchievedTarget { get; set; }

    public bool CheckTarget(int quota)
    {
        return AchievedTarget >= quota;
    }

    public void EndOfYearOperation(int quota)
    {
        if (!CheckTarget(quota))
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
        }
    }
}
public class BoardMember : Employee
{
    public void Resign()
    {
        OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
    }
}
