﻿using AutoMapper;
using BuldingManager.ApplicationDbContext;
using BuldingManager.Dto.UnitOwner;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Repo.UnitOwner;

public class UnitOwnerRepository:IUnitOwnerRepository
{
    private readonly BuildingDbContext _context;
    private readonly IMapper _mapper;

    public UnitOwnerRepository(BuildingDbContext context, IMapper mapper)
    {
        _context=context;
        _mapper=mapper;
        
    }
    
    
    public async Task<IEnumerable<Entities.UnitOwner>> GetUnitOwners(string extra)
    {
       var unitOwners = await _context.UnitOwners.Include(u=>u.Unit).Include(u=>u.Unit.Building).Include(u=>u.person).ToListAsync();
       return unitOwners;
    }

    public async Task<Entities.UnitOwner> GetUnitOwner(int id )
    {
        var unitOwner = await _context.UnitOwners.FindAsync(id);
        return unitOwner;
    }

    public Task CreateUnitOwner(Entities.UnitOwner unitOwner)
    {
        _context.Add(unitOwner);
        return _context.SaveChangesAsync();
    }

    public async Task UpdateUnitOwner(int id, Entities.UnitOwner unitOwner)
    {
        var unitOwnerEntity = await GetUnitOwner(id);
        if (unitOwnerEntity == null)
        {
            throw new Exception("Unit Owner not found");
        }
        _mapper.Map(unitOwner, unitOwnerEntity);
        _context.Entry(unitOwnerEntity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        
    }

    public async Task DeleteUnitOwner(int id)
    {
        
        var unitOwnerEntity = await GetUnitOwner(id);
        if (unitOwnerEntity == null)
        {
            throw new Exception("Unit Owner not found");
        }
         _context.Remove(unitOwnerEntity);
         _context.SaveChangesAsync();
    }
}