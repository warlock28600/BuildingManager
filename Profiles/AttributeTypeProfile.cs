using AutoMapper;
using BuldingManager.Dto.AttributeType;
using BuldingManager.Entities;

namespace BuldingManager.Profiles;

public class AttributeTypeProfile:Profile
{
    public AttributeTypeProfile()
    {

        CreateMap<AttributeType, AttributeTypeGetDto>().ReverseMap();
        CreateMap<AttributeType, AttributeTypeCreateAndUpdateDto>().ReverseMap();
        CreateMap<AttributeType, AttributeType>()
              .ForMember(dest => dest.AttributeTypeId, opt => opt.Ignore());
    }
}