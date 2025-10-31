using BuldingManager.Dto.AttributeType;

namespace BuldingManager.Repo.AttributeType;

public interface IAttributeTypeRepository
{
    Task<IEnumerable<Entities.AttributeType>> GetAttributeTypes();
    Task<Entities.AttributeType> GetAttributeType(int id);
    Task<bool> CreateAttributeType(Entities.AttributeType attributeType);
    Task<bool> UpdateAttributeType(int id, Entities.AttributeType attributeType);
    Task<bool> DeleteAttributeType(int id);
}