using BuldingManager.Dto.UnitOwner;
using BuldingManager.Services.UnitOwner;
using Microsoft.AspNetCore.Mvc;

namespace BuldingManager.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class UnitOwnerController:ControllerBase
{
    private readonly IUnitOwnerService _unitOwnerService;

    public UnitOwnerController(IUnitOwnerService unitOwnerService)
    {
        _unitOwnerService = unitOwnerService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<GetUnitOwnerDto>>> GetUnitOwners()
    {
        var unitOwners = await _unitOwnerService.GetUnitOwners();
        return Ok(unitOwners);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetUnitOwnerDto>> GetUnitOwner(int id)
    {
        var unitOwner = await _unitOwnerService.GetUnitOwner(id);
        return Ok(unitOwner);
    }

    [HttpPost]
    public Task CreateUnitOwner(CreateUnitOwnerDto unitOwner)
    {
        return _unitOwnerService.CreateUnitOwner(unitOwner);
    }

    [HttpPut("{id}")]
    public async Task UpdateUnitOwner(int id, CreateUnitOwnerDto unitOwner)
    {
        await _unitOwnerService.UpdateUnitOwner(id, unitOwner);
    }

    [HttpDelete("{id}")]
    public Task DeleteUnitOwner(int id)
    {
        return _unitOwnerService.DeleteUnitOwner(id);
    }
    
}