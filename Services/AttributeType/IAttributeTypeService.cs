using BuldingManager.Dto.AttributeType;

namespace BuldingManager.Services.AttributeType;

public interface IAttributeTypeService
{
    public Task<IEnumerable<AttributeTypeDto>> GetAttributeTypes();
    public Task<AttributeTypeDto> GetAttributeType(int attributeTypeId);
    public Task CreateAttributeType(AttributeTypeDto attributeType);
    public Task UpdateAttributeType(int id,AttributeTypeDto attributeType);
    public Task DeleteAttributeType(int id);
}