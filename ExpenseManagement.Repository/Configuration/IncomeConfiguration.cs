using ExpenseManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseManagement.Repository.Configuration;

public class IncomeConfiguration : IEntityTypeConfiguration<Income>
{
    public void Configure(EntityTypeBuilder<Income> builder)
    {
        builder.HasKey(i => i.Id);

        builder.HasOne(i => i.User)
            .WithMany(u => u.Incomes)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Property(i => i.Amount).HasColumnType("DECIMAL(18, 2)");

        builder.Property(i => i.Source).HasMaxLength(100).IsRequired();

        builder.Property(i => i.CreatedAt).HasDefaultValueSql("GETDATE()");
    }
}