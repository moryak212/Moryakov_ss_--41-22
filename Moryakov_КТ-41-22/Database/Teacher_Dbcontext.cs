using Microsoft.EntityFrameworkCore;
using Moryakov_КТ_41_22.Models;

namespace Moryakov_КТ_41_22.Database
{
    public class Teacher_Dbcontext : DbContext
    {
        public Teacher_Dbcontext(DbContextOptions<Teacher_Dbcontext> options) : base(options) { }

        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Workload> Workloads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.HeadTeacher)
                .WithMany()
                .HasForeignKey(d => d.HeadTeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.AcademicDegree)
                .WithMany(ad => ad.Teachers)
                .HasForeignKey(t => t.AcademicDegreeId);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Position)
                .WithMany(p => p.Teachers)
                .HasForeignKey(t => t.PositionId);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Department)
                .WithMany(d => d.Teachers)
                .HasForeignKey(t => t.DepartmentId);

            modelBuilder.Entity<Workload>()
                .HasOne(w => w.Teacher)
                .WithMany(t => t.Workloads)
                .HasForeignKey(w => w.TeacherId);

            modelBuilder.Entity<Workload>()
                .HasOne(w => w.Discipline)
                .WithMany(d => d.Workloads)
                .HasForeignKey(w => w.DisciplineId);
        }
    }
}
