using ExpenseManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseManagement.Repository.Configuration;

public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
{
    public void Configure(EntityTypeBuilder<Expense> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.HasOne(e => e.User)
            .WithMany(u => u.Expenses)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(e => e.Amount).HasColumnType("DECIMAL(18, 2)");
        
        builder.Property(e => e.Description).HasMaxLength(255);

        builder.Property(e => e.CreatedAt).HasDefaultValueSql("GETDATE()");
    }
}