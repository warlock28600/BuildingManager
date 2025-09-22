using AutoMapper;
using BuldingManager.Dto.Unit;
using BuldingManager.Entities;

namespace BuldingManager.Profiles;

public class UnitProfile:Profile
{
    public UnitProfile()
    {
        CreateMap<UnitCreateDto, UnitEntity>().ReverseMap();
        CreateMap<UnitGetDto, UnitEntity>().ReverseMap();
    }
}