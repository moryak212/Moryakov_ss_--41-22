using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moryakov_КТ_41_22.Models;

namespace Moryakov_КТ_41_22.Data.Configurations
{
    public class AcademicDegreeConfiguration : IEntityTypeConfiguration<AcademicDegree>
    {
        public void Configure(EntityTypeBuilder<AcademicDegree> builder)
        {
            builder.HasKey(ad => ad.AcademicDegreeId);

            builder.Property(ad => ad.Name)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }

}
