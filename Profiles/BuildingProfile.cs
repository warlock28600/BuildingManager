using AutoMapper;
using BuldingManager.Dto;
using BuldingManager.Entities;

namespace BuldingManager.Profiles;

public class BuildingProfile : Profile
{
    public BuildingProfile()
    {
        CreateMap<BuildingEntity, BuildingCreateDto>().ReverseMap();
    }
}