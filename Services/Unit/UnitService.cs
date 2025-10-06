using AutoMapper;
using BuldingManager.Dto.Unit;
using BuldingManager.Entities;
using BuldingManager.Repo.BuildingRepo;
using BuldingManager.Repo.UnitRepo;

namespace BuldingManager.Services.Unit;

public class UnitService:IUnitService
{
    private readonly IUnitRepository _unitRepository;
    private readonly IMapper _imapper;
    public UnitService(IMapper imapper, IUnitRepository unitRepository)
    {
        _imapper = imapper;
        _unitRepository = unitRepository;
    }
    
    public async Task<UnitGetDto> GetUnitAsync(int id)
    {
        var unit = await _unitRepository.GetUnitById(id);
        return _imapper.Map<UnitGetDto>(unit);
    }

    public async Task<IEnumerable<UnitGetDto>> GetUnitsAsync()
    {
        var units = await _unitRepository.GetAllUnits();
        return _imapper.Map<IEnumerable<UnitGetDto>>(units);
    }

    public Task CreateUnit(UnitCreateDto unitCreateDto)
    {
        var unitEntity=_imapper.Map<UnitEntity>(unitCreateDto);
        return _unitRepository.CreateUnit(unitEntity);
    }

    public async Task UpdateUnit(int id, UnitCreateDto unitCreateDto)
    {
        await _unitRepository.UpdateUnit(id, unitCreateDto);
    }

    public Task DeleteUnit(int id)
    {
       return _unitRepository.DeleteUnit(id);
    }
}