using BuldingManager.Dto.AttributeType;

namespace BuldingManager.Repo.AttributeType;

public interface IAttributeTypeRepository
{
    Task<IEnumerable<Entities.AttributeType>> GetAttributeTypes();
    Task<Entities.AttributeType> GetAttributeType(int id);
    Task CreateAttributeType(Entities.AttributeType attributeType);
    Task UpdateAttributeType(int id, Entities.AttributeType attributeType);
    Task DeleteAttributeType(int id);
}