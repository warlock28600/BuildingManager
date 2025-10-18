using AutoMapper;

namespace BuldingManager.Profiles
{
    public class CompoundProfile:Profile
    {
        public CompoundProfile()
        {
            CreateMap<Entities.Compounds,Dto.Compound.CompoundCreateDto>().ReverseMap();
            CreateMap<Entities.Compounds,Dto.Compound.CompoundGetDto>().ReverseMap();
            CreateMap<Entities.Compounds,Entities.Compounds>().ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
