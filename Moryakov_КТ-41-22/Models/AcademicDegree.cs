namespace Moryakov_КТ_41_22.Models
{
    public class AcademicDegree
    {
        public int AcademicDegreeId { get; set; }
        public string Name { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }

}
