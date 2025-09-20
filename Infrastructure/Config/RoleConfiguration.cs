using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "admin-id",
                ConcurrencyStamp = "8e7e3e64-0dd8-4cd0-b96e-0e836ad7d14c",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = "customer-id",
                ConcurrencyStamp = "c15c5f24-8876-47ce-bcfb-e7410d991e66",
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            }
        );
    }
}
