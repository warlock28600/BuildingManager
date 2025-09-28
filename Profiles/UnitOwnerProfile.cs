using AutoMapper;
using BuldingManager.Dto.UnitOwner;
using BuldingManager.Entities;

namespace BuldingManager.Profiles;

public class UnitOwnerProfile:Profile
{
    public UnitOwnerProfile()
    {
        CreateMap<CreateUnitOwnerDto, UnitOwner>().ReverseMap();
    }
}