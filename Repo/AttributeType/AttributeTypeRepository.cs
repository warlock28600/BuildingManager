using AutoMapper;
using BuldingManager.ApplicationDbContext;
using BuldingManager.Dto.AttributeType;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Repo.AttributeType;

public class AttributeTypeRepository : IAttributeTypeRepository
{
    private readonly BuildingDbContext _context;
    private readonly IMapper _mapper;

    public AttributeTypeRepository(BuildingDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Entities.AttributeType>> GetAttributeTypes()
    {
        var attributeTypes = await _context.AttributeTypes.ToListAsync();
        return attributeTypes;
    }

    public async Task<Entities.AttributeType> GetAttributeType(int id)
    {
        var attributeType = await _context.AttributeTypes.SingleOrDefaultAsync(a => a.AttributeTypeId == id);

        if (attributeType == null)
        {
            throw new Exception("Attribute type not found");
        }
        return attributeType;
    }

    public async Task<bool> CreateAttributeType(Entities.AttributeType attributeType)
    {
        _context.AttributeTypes.Add(attributeType);
        var created = await _context.SaveChangesAsync();
        return created > 0;
    }

    public async Task<bool> UpdateAttributeType(int id, Entities.AttributeType attributeType)
    {
        var attributeTypeToUpdate = await _context.AttributeTypes.SingleOrDefaultAsync(a => a.AttributeTypeId == id);
        if (attributeTypeToUpdate == null)
            throw new Exception("Attribute type not found");

        // Use AutoMapper to update properties
        _mapper.Map(attributeType, attributeTypeToUpdate);

        var updated = await _context.SaveChangesAsync();
        return updated > 0;
    }

    public async Task<bool> DeleteAttributeType(int id)
    {
        var attributeTypeToDelete = await GetAttributeType(id);
        if (attributeTypeToDelete == null)
        {
            throw new Exception("Attribute type not found");
        }
        _context.AttributeTypes.Remove(attributeTypeToDelete);
        var deleted = await _context.SaveChangesAsync();
        return deleted > 0;
    }
}