using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class CustomerConfiguration:IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.customerId);
        
        builder.HasOne(c => c.Role)
            .WithMany(r => r.Customers)
            .HasForeignKey(c => c.roleId);
        
        
        
        
    }
}