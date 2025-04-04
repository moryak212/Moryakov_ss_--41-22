namespace Moryakov_КТ_41_22.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FullName { get; set; }

        public int AcademicDegreeId { get; set; }
        public AcademicDegree AcademicDegree { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Workload> Workloads { get; set; }
        public ICollection<Department> DepartmentsHeaded { get; set; }
    }

}
