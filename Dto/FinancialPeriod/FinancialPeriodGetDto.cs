using BuldingManager.Entities;

namespace BuldingManager.Dto.FinancialPeriod
{
    public class FinancialPeriodGetDto:BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
