using AutoMapper;

namespace BuldingManager.Profiles
{
    public class FinancialPeriodProfile:Profile
    {
        public FinancialPeriodProfile()
        {
            CreateMap<Entities.FinancialPeriod,Dto.FinancialPeriod.FinancialPeriodCreateDto>().ReverseMap();
            CreateMap<Entities.FinancialPeriod,Dto.FinancialPeriod.FinancialPeriodGetDto>().ReverseMap();
            CreateMap<Entities.FinancialPeriod,Entities.FinancialPeriod>().ForMember(dest => dest.Id, opt => opt.Ignore()); ;
        }
    }
}
