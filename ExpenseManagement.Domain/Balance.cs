namespace ExpenseManagement.Domain;

public record Balance
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public decimal Money { get; init; }
    public decimal Income { get; init; }
    public decimal Expense { get; init; }
}