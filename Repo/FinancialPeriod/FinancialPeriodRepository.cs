
using AutoMapper;
using BuldingManager.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Repo.FinancialPeriod
{
    public class FinancialPeriodRepository : IFinancialPeriodRepository
    {
        private readonly BuildingDbContext _context;
        private readonly IMapper _mapper;

        public FinancialPeriodRepository(BuildingDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateFinancialPeriod(Entities.FinancialPeriod financialPeriod)
        {
            _context.FinancialPeriods.Add(financialPeriod);
            var created = await _context.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> DeleteFinancialPeriod(int id)
        {
            var financialPeriod = await GetFinancialPeriodById(id);
            if (financialPeriod == null)
            {
                throw new Exception("Financial Period not found");
            }
            _context.FinancialPeriods.Remove(financialPeriod);
            var deleted = await _context.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<Entities.FinancialPeriod?> GetFinancialPeriodById(int id)
        {
            var financialPeriod = await _context.FinancialPeriods.FirstOrDefaultAsync(f => f.Id == id);
            return financialPeriod;
        }

        public async Task<IEnumerable<Entities.FinancialPeriod>> GetFinancialPeriods()
        {
            var financialPeriods = await _context.FinancialPeriods.ToListAsync();
            return financialPeriods;
        }

        public async Task<bool> UpdateFinancialPeriod(int id, Entities.FinancialPeriod financialPeriod)
        {
            var financialPeriodToUpdate = await GetFinancialPeriodById(id);
            if (financialPeriodToUpdate == null)
            {
                throw new Exception("Financial Period not found");
            }
            _mapper.Map(financialPeriod, financialPeriodToUpdate);
            var updated = await _context.SaveChangesAsync();
            return updated > 0;
        }
    }
}
