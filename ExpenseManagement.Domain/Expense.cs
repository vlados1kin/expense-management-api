namespace ExpenseManagement.Domain;

public class Expense
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public User? User { get; set; }
    public Category? Category { get; set; }
}