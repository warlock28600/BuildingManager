namespace BuldingManager.Repo.FinancialPeriod
{
    public interface IFinancialPeriodRepository
    {
        public Task<IEnumerable<Entities.FinancialPeriod>> GetFinancialPeriods();
        public Task<Entities.FinancialPeriod?> GetFinancialPeriodById(int id);
        public Task<bool> CreateFinancialPeriod(Entities.FinancialPeriod financialPeriod);
        public Task<bool> UpdateFinancialPeriod(int id,Entities.FinancialPeriod financialPeriod);
        public Task<bool> DeleteFinancialPeriod(int id);
    }
}
