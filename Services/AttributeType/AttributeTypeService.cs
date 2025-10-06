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

    public async Task<IEnumerable<AttributeTypeDto>> GetAttributeTypes()
    {
        var attributeTypes =await _repository.GetAttributeTypes();
        return _mapper.Map<IEnumerable<AttributeTypeDto>>(attributeTypes);
    }

    public async Task<AttributeTypeDto> GetAttributeType(int attributeTypeId)
    {
        var attributeType =await _repository.GetAttributeType(attributeTypeId);
        return _mapper.Map<AttributeTypeDto>(attributeType);
    }

    public Task CreateAttributeType(AttributeTypeDto attributeType)
    {
        _repository.CreateAttributeType(_mapper.Map<Entities.AttributeType>(attributeType));
        return Task.CompletedTask;
    }

    public Task UpdateAttributeType(int id, AttributeTypeDto attributeType)
    {
        _repository.UpdateAttributeType(id, _mapper.Map<Entities.AttributeType>(attributeType));
        return Task.CompletedTask;
    }

    public Task DeleteAttributeType(int id)
    {
        _repository.DeleteAttributeType(id);
        return Task.CompletedTask;
    }
}