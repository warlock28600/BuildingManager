using AutoMapper;
using BuldingManager.Dto.AttributeType;
using BuldingManager.Repo.AttributeType;

namespace BuldingManager.Services.AttributeType;

public class AttributeTypeService: IAttributeTypeService {
    
    private readonly IMapper _mapper;
    private readonly IAttributeTypeRepository _repository;

    public AttributeTypeService(IMapper mapper, IAttributeTypeRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<IEnumerable<AttributeTypeGetDto>> GetAttributeTypes()
    {
        var attributeTypes =await _repository.GetAttributeTypes();
        return _mapper.Map<IEnumerable<AttributeTypeGetDto>>(attributeTypes);
    }

    public async Task<AttributeTypeGetDto> GetAttributeType(int attributeTypeId)
    {
        var attributeType =await _repository.GetAttributeType(attributeTypeId);
        return _mapper.Map<AttributeTypeGetDto>(attributeType);
    }

    public Task CreateAttributeType(AttributeTypeCreateAndUpdateDto attributeType)
    {
        _repository.CreateAttributeType(_mapper.Map<Entities.AttributeType>(attributeType));
        return Task.CompletedTask;
    }

    public async Task UpdateAttributeType(int id, AttributeTypeCreateAndUpdateDto attributeType)
    {
       await _repository.UpdateAttributeType(id, _mapper.Map<Entities.AttributeType>(attributeType));
       
    }

    public async Task DeleteAttributeType(int id)
    {
      await _repository.DeleteAttributeType(id);
       
    }
}