namespace ExpenseManagement.Shared.DTO;

public record UserForCreationDto
{
    public string? Username { get; init; }
    public string? Email { get; init; }
    public string? PasswordHash { get; init; }
}