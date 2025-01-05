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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("MyStudents");

            builder.HasKey(c => c.StudentId);

            builder.Property(s => s.Name).HasMaxLength(20).IsRequired();

            builder.Property(p => p.Surname).HasColumnName("Soyisim").HasColumnType("nvarchar(200)");

            builder.Property(p => p.Birthdate).HasDefaultValueSql("GETDATE()");


            //builder.Property(p => p.CreateDate).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.Now);

            builder.Property(p => p.CreateDate).ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.UpdateDate).ValueGeneratedOnUpdate().HasDefaultValueSql("GETDATE()");

            










        }
    }
}
