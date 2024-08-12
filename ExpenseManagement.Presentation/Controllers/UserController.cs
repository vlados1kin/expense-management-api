using ExpenseManagement.Domain;
using ExpenseManagement.Repository;
using ExpenseManagement.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManagement.Presentation.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly RepositoryContext _context;

    public UserController(RepositoryContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _context.Users.ToListAsync();
        await _context.SaveChangesAsync();
        return Ok(users);
    }

    [HttpGet]
    [Route("{id:guid}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        var user = await _context.Users.FirstAsync(u => u.Id == id);
        await _context.SaveChangesAsync();
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] UserForCreationDto userDto)
    {
        User? user;
        using (var transaction = await _context.Database.BeginTransactionAsync())
        {
            try
            {
                user = new User
                {
                    Username = userDto.Username,
                    Email = userDto.Email,
                    PasswordHash = userDto.PasswordHash
                };
                _context.Users.Add(user);
                var balance = new Balance
                {
                    User = user,
                    Money = 0,
                    Income = 0,
                    Expense = 0
                };
                _context.Balances.Add(balance);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        return Ok();
    }

    [HttpDelete]
    [Route("{id:guid}")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        var user = await _context.Users.FirstAsync(u => u.Id == id);
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return Ok();
    }

}