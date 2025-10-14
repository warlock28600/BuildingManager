namespace BuldingManager.Entities
{
    public class ResidentEntity
    {
        public int Id{ get; set; }
        public int PersonId { get; set; }
        public Persons Person { get; set; }
        public int UnitId { get; set; }
        public UnitEntity Unit { get; set; }
        public DateTime? MoveInDate { get; set; }
        public DateTime? MoveOutDate { get; set; }
        public string ResidentType { get; set; }
    }
}
