using AutoMapper;

namespace BuldingManager.Profiles
{
    public class ExpenseProfile:Profile
    {
        public ExpenseProfile()
        {
            CreateMap<Entities.Expense, Dto.Expense.ExpenceCreateDto>().ReverseMap();
            CreateMap<Entities.Expense, Dto.Expense.ExpenseGetDto>().ReverseMap();
            CreateMap<Entities.Expense, Entities.Expense>()
              .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
