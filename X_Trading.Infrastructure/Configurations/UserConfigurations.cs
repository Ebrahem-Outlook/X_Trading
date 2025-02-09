using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using X_Trading.Domain.Users;

namespace X_Trading.Infrastructure.Configurations;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

        builder.HasIndex(user => user.Id).IsUnique();

        builder.Property(user => user.FirstName).HasMaxLength(50);

        builder.Property(user => user.LastName).HasMaxLength(50);

        builder.Property(user => user.Email).HasMaxLength(50);

        builder.Property(user => user.Password).HasMaxLength(50);
    }
}
