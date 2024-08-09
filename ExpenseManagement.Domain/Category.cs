namespace ExpenseManagement.Domain;

public class Category
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public User? User { get; set; }
    public ICollection<Expense>? Expenses { get; set; }
}