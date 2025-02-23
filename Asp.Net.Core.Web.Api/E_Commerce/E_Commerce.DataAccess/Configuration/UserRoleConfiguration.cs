using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class UserRoleConfiguration:IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasKey(ur => new {ur.userId,ur.roleId});
        
        builder.HasOne(ur=>ur.User)
            .WithMany(u=>u.UserRoles)
            .HasForeignKey(ur=>ur.userId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(ur=>ur.Role)
            .WithMany(u=>u.UserRoles)
            .HasForeignKey(ur=>ur.roleId)
            .OnDelete(DeleteBehavior.Cascade);
        
        
        
        
    }
}