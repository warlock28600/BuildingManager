using AutoMapper;
using BuldingManager.Dto.AttributeType;
using BuldingManager.Entities;

namespace BuldingManager.Profiles;

public class AttributeTypeProfile:Profile
{
    public AttributeTypeProfile()
    {

        CreateMap<AttributeTypeDto, AttributeType>().ReverseMap();
    }
}