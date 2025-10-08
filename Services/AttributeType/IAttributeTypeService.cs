using BuldingManager.Dto.AttributeType;

namespace BuldingManager.Services.AttributeType;

public interface IAttributeTypeService
{
    public Task<IEnumerable<AttributeTypeGetDto>> GetAttributeTypes();
    public Task<AttributeTypeGetDto> GetAttributeType(int attributeTypeId);
    public Task CreateAttributeType(AttributeTypeCreateAndUpdateDto attributeType);
    public Task UpdateAttributeType(int id,AttributeTypeCreateAndUpdateDto attributeType);
    public Task DeleteAttributeType(int id);
}