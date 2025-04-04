namespace Moryakov_КТ_41_22.Models
{
    public class Discipline
    {
        public int DisciplineId { get; set; }
        public string Name { get; set; }

        public ICollection<Workload> Workloads { get; set; }
    }

}
