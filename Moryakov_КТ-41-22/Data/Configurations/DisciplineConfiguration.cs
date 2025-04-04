using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Moryakov_КТ_41_22.Models;

namespace Moryakov_КТ_41_22.Data.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.HasKey(d => d.DisciplineId);

            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(150);
        }
    }

}
