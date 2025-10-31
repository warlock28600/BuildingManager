﻿
using AutoMapper;
using BuldingManager.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Repo.Attribute
{
    public class AttributeRepository : IAttributeRepository
    {
        private readonly BuildingDbContext _context;
        private readonly IMapper _mapper;

        public AttributeRepository(BuildingDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateAttribute(Entities.Attribute attribute)
        {
            _context.Attributes.Add(attribute);
            var created = await _context.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> DeleteAttribute(int id)
        {
            var attribute = await GetAttributeById(id);
            if (attribute == null)
            {
                throw new Exception("Attribute not found");
            }
            _context.Attributes.Remove(attribute);
            var deleted = await _context.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<List<Entities.Attribute>> GetAllAttributes()
        {
            var attributes = await _context.Attributes.ToListAsync();
            return attributes;
        }

        public async Task<Entities.Attribute> GetAttributeById(int id)
        {
            var attribute = await _context.Attributes.FirstOrDefaultAsync(a => a.AttributeId == id);
            if (attribute == null)
            {
                throw new Exception("Attribute not found");
            }
            return attribute;
        }

        public async Task<bool> UpdateAttribute(int id, Entities.Attribute attribute)
        {
            var attributeToUpdate = await GetAttributeById(id);
            if (attributeToUpdate == null)
            {
                throw new Exception("Attribute not found");
            }
            _mapper.Map(attribute, attributeToUpdate);
            var updated = await _context.SaveChangesAsync();
            return updated > 0;
        }
    }
}
