using AutoMapper;
using BuldingManager.Dto.Attribute;
using BuldingManager.Repo.Attribute;

namespace BuldingManager.Services.Attribute
{
    public class AttributeService : IAttributeService
    {
        private readonly IAttributeRepository _attributeRepository;
        private readonly IMapper _mapper;

        public AttributeService(IAttributeRepository attributeRepository, IMapper mapper)
        {
            _attributeRepository = attributeRepository;
            _mapper = mapper;
        }

        public async Task CreateAttribute(attributeCreateDto attribute)
        {
           await _attributeRepository.CreateAttribute(_mapper.Map<Entities.Attribute>(attribute));
        }

        public Task DeleteAttribute(int id)
        {
            return  _attributeRepository.DeleteAttribute(id);
        }

        public async Task<AttributeGetDto> GetAttribute(int attributeId)
        {
            var attribute = await _attributeRepository.GetAttributeById(attributeId);
            return _mapper.Map<AttributeGetDto>(attribute);
        }

        public async Task<IEnumerable<AttributeGetDto>> GetAttributes()
        {
            var attributes = await  _attributeRepository.GetAllAttributes();
            return _mapper.Map<IEnumerable<AttributeGetDto>>(attributes);
        }

        public async Task UpdateAttribute(int id, attributeCreateDto attribute)
        {
            await _attributeRepository.UpdateAttribute(id, _mapper.Map<Entities.Attribute>(attribute));
        }
    }
}
