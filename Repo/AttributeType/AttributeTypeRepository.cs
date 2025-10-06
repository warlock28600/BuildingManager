using AutoMapper;
using BuldingManager.ApplicationDbContext;
using BuldingManager.Dto.AttributeType;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Repo.AttributeType;

public class AttributeTypeRepository:IAttributeTypeRepository
{
    private readonly BuildingDbContext _context;
    private readonly IMapper _mapper;

    public AttributeTypeRepository(BuildingDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Entities.AttributeType>> GetAttributeTypes()
    {
        var attributeTypes = await _context.AttributeTypes.ToListAsync();
        return attributeTypes;
    }

    public async Task<Entities.AttributeType> GetAttributeType(int id)
    {
        var attributeType = await _context.AttributeTypes.FindAsync(id);
        if (attributeType == null)
        {
         throw   new Exception("Attribute type not found");
        }
        return attributeType;
    }

    public Task CreateAttributeType(Entities.AttributeType attributeType)
    {
        _context.AttributeTypes.Add(attributeType);
        return _context.SaveChangesAsync();
    }

    public async Task UpdateAttributeType(int id, Entities.AttributeType attributeType)
    {
        var attributeTypeToUpdate = await GetAttributeType(id);
        if (attributeTypeToUpdate == null)
        {
            throw new Exception("Attribute type not found");
        }
        _mapper.Map(attributeType, attributeTypeToUpdate);
        _context.Entry(attributeTypeToUpdate).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAttributeType(int id)
    {
        var attributeTypeToDelete = await GetAttributeType(id);
        if (attributeTypeToDelete == null)
        {
            throw new Exception("Attribute type not found");
        }
        _context.AttributeTypes.Remove(attributeTypeToDelete);
        await _context.SaveChangesAsync();
    }
}