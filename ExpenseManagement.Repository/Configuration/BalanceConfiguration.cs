using ExpenseManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseManagement.Repository.Configuration;

public class BalanceConfiguration : IEntityTypeConfiguration<Balance>
{
    public void Configure(EntityTypeBuilder<Balance> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Money).HasColumnType("DECIMAL(18, 2)");
        
        builder.Property(b => b.Income).HasColumnType("DECIMAL(18, 2)");
        
        builder.Property(b => b.Expense).HasColumnType("DECIMAL(18, 2)");
    }
}