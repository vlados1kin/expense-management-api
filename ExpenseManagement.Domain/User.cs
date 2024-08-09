using System.Collections;

namespace ExpenseManagement.Domain;

public class User
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public ICollection<Category>? Categories { get; set; }
    public ICollection<Income>? Incomes { get; set; }
    public ICollection<Expense>? Expenses { get; set; }
    public Balance? Balance { get; set; }
}