namespace Moryakov_КТ_41_22.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Name { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }

}
