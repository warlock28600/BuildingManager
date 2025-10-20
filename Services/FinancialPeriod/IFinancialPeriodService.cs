using BuldingManager.Dto.FinancialPeriod;

namespace BuldingManager.Services.FinancialPeriod
{
    public interface IFinancialPeriodService
    {
        public Task<IEnumerable<FinancialPeriodGetDto>> GetFinancialPeriods();
        public Task<FinancialPeriodGetDto> GetFinancialPeriodById(int id);
        public Task<Boolean> CreateFinancialPeriod(FinancialPeriodCreateDto dto);
        public Task<Boolean> UpdateFinancialPeriod(int id, FinancialPeriodCreateDto dto);
        public Task<Boolean> DeleteFinancialPeriod(int id);
    }
}
