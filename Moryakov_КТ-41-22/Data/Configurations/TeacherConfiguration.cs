using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Moryakov_КТ_41_22.Models;

namespace Moryakov_КТ_41_22.Data.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.TeacherId);

            builder.Property(t => t.FullName)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.HasOne(t => t.AcademicDegree)
                   .WithMany(ad => ad.Teachers)
                   .HasForeignKey(t => t.AcademicDegreeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Position)
                   .WithMany(p => p.Teachers)
                   .HasForeignKey(t => t.PositionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Department)
                   .WithMany(d => d.Teachers)
                   .HasForeignKey(t => t.DepartmentId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
