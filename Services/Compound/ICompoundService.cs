using BuldingManager.Dto.Compound;

namespace BuldingManager.Services.Compound
{
    public interface ICompoundService
    {
        public Task<IEnumerable<CompoundGetDto>> GetCompounds();
        public Task<CompoundGetDto> GetCompoundById(int id);
        public Task<Boolean> CreateCompound(CompoundCreateDto compoundCreateDto);
        public Task<Boolean> UpdateCompound(int id, CompoundCreateDto compoundCreateDto);
        public Task<Boolean> DeleteCompound(int id);
    }
}
