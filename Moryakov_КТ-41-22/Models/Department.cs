namespace Moryakov_КТ_41_22.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public DateTime FoundationYear { get; set; }

        public int HeadTeacherId { get; set; }
        public Teacher HeadTeacher { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }

}
