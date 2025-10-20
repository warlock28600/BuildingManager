namespace BuldingManager.Entities
{
    public class FinancialPeriod:BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}
