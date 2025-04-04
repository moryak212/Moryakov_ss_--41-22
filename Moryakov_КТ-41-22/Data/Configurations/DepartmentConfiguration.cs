using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Moryakov_КТ_41_22.Models;

namespace Moryakov_КТ_41_22.Data.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.DepartmentId);

            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(d => d.FoundationYear)
                   .IsRequired();

            builder.HasOne(d => d.HeadTeacher)
                   .WithMany(t => t.DepartmentsHeaded)
                   .HasForeignKey(d => d.HeadTeacherId)
                   .OnDelete(DeleteBehavior.Restrict); // важно для избежания каскадного удаления
        }
    }

}
