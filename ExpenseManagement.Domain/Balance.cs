namespace ExpenseManagement.Domain;

public class Balance
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public decimal Money { get; set; }
    public decimal Income { get; set; }
    public decimal Expense { get; set; }
}