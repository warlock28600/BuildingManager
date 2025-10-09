using AutoMapper;

namespace BuldingManager.Profiles
{
    public class AttributeProfile:Profile
    {
        public AttributeProfile()
        {
            CreateMap<Entities.Attribute,Dto.Attribute.attributeCreateDto>().ReverseMap();
            CreateMap<Entities.Attribute, Dto.Attribute.AttributeGetDto>().ReverseMap();
            CreateMap<Entities.Attribute, Entities.Attribute>().ForMember(dest=>dest.AttributeId,opt=>opt.Ignore());
        }
    }
}
