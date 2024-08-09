namespace ExpenseManagement.Domain;

public record Expense
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public Guid CategoryId { get; init; }
    public decimal Amount { get; init; }
    public DateTime Date { get; init; }
    public string? Description { get; init; }
    public DateTime CreatedAt { get; init; }
}