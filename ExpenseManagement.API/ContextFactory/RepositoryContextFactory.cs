using ExpenseManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ExpenseManagement.API.ContextFactory;

public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
    public RepositoryContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json");
        var connection = builder.Build().GetConnectionString("sqlConnection");
        var options = new DbContextOptionsBuilder<RepositoryContext>()
            .UseSqlServer(connection, m => m.MigrationsAssembly("ExpenseManagement.API")).Options;
        return new RepositoryContext(options);
    }
}