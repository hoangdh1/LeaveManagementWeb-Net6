using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "6fa7a15d-b065-41fe-94de-3d700a365586",
                    UserId = "8fa7a15d-b065-41fe-94de-3d700a365586"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7fa7a15d-b065-41fe-94de-3d700a365586",
                    UserId = "9fa7a15d-b065-41fe-94de-3d700a365586"
                }
                );
        }
    }
}