namespace ExpenseManagement.Domain;

public record Income
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public decimal Amount { get; init; }
    public string? Source { get; init; }
    public DateTime Date { get; init; }
    public DateTime CreatedAt { get; init; }
}