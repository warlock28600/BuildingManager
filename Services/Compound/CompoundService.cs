using AutoMapper;
using BuldingManager.Dto.Compound;
using BuldingManager.Repo.CompoundRepo;

namespace BuldingManager.Services.Compound
{
    public class CompoundService : ICompoundService
    {
        private readonly ICompoundRepository _compoundRepository;
        private readonly IMapper _mapper;
        public CompoundService(ICompoundRepository compoundRepository, IMapper mapper)
        {
            _compoundRepository = compoundRepository;
            _mapper = mapper;
        }
        public async Task<bool> CreateCompound(CompoundCreateDto compoundCreateDto)
        {
            return await _compoundRepository.CreateCompound(_mapper.Map<Entities.Compounds>(compoundCreateDto));
        }

        public async Task<bool> DeleteCompound(int id)
        {
            return await _compoundRepository.DeleteCompound(id);
        }

        public async Task<CompoundGetDto> GetCompoundById(int id)
        {
            var compound = await _compoundRepository.GetCompoundById(id);
            return _mapper.Map<CompoundGetDto>(compound);

        }

        public async Task<IEnumerable<CompoundGetDto>> GetCompounds()
        {
            var compounds = await _compoundRepository.GetCompounds();
            return _mapper.Map<IEnumerable<CompoundGetDto>>(compounds);
        }

        public async Task<bool> UpdateCompound(int id, CompoundCreateDto compoundCreateDto)
        {
            return await _compoundRepository.UpdateCompound(id, _mapper.Map<Entities.Compounds>(compoundCreateDto));
        }
    }
}
