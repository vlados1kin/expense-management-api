namespace ExpenseManagement.Domain;

public record Category
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
    public DateTime CreatedAt { get; init; }
}