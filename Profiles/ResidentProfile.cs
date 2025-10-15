using AutoMapper;
using BuldingManager.Entities;

namespace BuldingManager.Profiles
{
    public class ResidentProfile:Profile
    {
        public ResidentProfile()
        {
            CreateMap<Dto.Residents.ResidentCreateDto, Entities.ResidentEntity>().ReverseMap();
            CreateMap<Dto.Residents.ResidentGetDto, Entities.ResidentEntity>().ReverseMap();
            CreateMap<Entities.ResidentEntity, Entities.ResidentEntity>()
              .ForMember(dest => dest.Id, opt => opt.Ignore());

        }
    }
}
