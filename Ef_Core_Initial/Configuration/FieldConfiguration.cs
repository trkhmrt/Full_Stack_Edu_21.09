using Ef_Core_Initial.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Configuration
{
    public class FieldConfiguration : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
           
            builder.HasMany(f=>f.Students).WithOne(s=>s.Field).HasForeignKey(s=>s.FieldId).OnDelete(DeleteBehavior.Cascade);



        }
    }
}
