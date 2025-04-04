using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Moryakov_КТ_41_22.Models;

namespace Moryakov_КТ_41_22.Data.Configurations
{
    public class WorkloadConfiguration : IEntityTypeConfiguration<Workload>
    {
        public void Configure(EntityTypeBuilder<Workload> builder)
        {
            builder.HasKey(w => w.WorkloadId);

            builder.Property(w => w.Hours)
                   .IsRequired();

            builder.HasOne(w => w.Teacher)
                   .WithMany(t => t.Workloads)
                   .HasForeignKey(w => w.TeacherId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(w => w.Discipline)
                   .WithMany(d => d.Workloads)
                   .HasForeignKey(w => w.DisciplineId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
