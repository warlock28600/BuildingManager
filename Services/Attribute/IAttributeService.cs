namespace BuldingManager.Services.Attribute
{
    public interface IAttributeService
    {
        Task<IEnumerable<Dto.Attribute.AttributeGetDto>> GetAttributes();
        Task<Dto.Attribute.AttributeGetDto> GetAttribute(int attributeId);
        Task CreateAttribute(Dto.Attribute.attributeCreateDto attribute);
        Task UpdateAttribute(int id, Dto.Attribute.attributeCreateDto attribute);
        Task DeleteAttribute(int id);
    }
}
