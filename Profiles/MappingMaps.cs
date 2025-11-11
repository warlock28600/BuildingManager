using AutoMapper;
using BuldingManager.Dto;
using BuldingManager.Dto.AttributeType;
using BuldingManager.Dto.Unit;
using BuldingManager.Dto.UnitOwner;
using BuldingManager.Entities;

namespace BuldingManager.Profiles
{
    public class MappingMaps:Profile
    {
        public MappingMaps()
        {
            #region Attribute Profiles
            CreateMap<Entities.Attribute, Dto.Attribute.attributeCreateDto>().ReverseMap();
            CreateMap<Entities.Attribute, Dto.Attribute.AttributeGetDto>().ReverseMap();
            CreateMap<Entities.Attribute, Entities.Attribute>().ForMember(dest => dest.AttributeId, opt => opt.Ignore());
            #endregion

            #region AttribbuteType Profiles
            CreateMap<AttributeType, AttributeTypeGetDto>().ReverseMap();
            CreateMap<AttributeType, AttributeTypeCreateAndUpdateDto>().ReverseMap();
            CreateMap<AttributeType, AttributeType>()
                  .ForMember(dest => dest.AttributeTypeId, opt => opt.Ignore());
            #endregion

            #region Building Profiles
            CreateMap<BuildingEntity, BuildingCreateDto>().ReverseMap();
            CreateMap<BuildingEntity, BuildingGetDto>().ReverseMap();
            #endregion

            #region Compound Profiles
            CreateMap<Entities.Compounds, Dto.Compound.CompoundCreateDto>().ReverseMap();
            CreateMap<Entities.Compounds, Dto.Compound.CompoundGetDto>().ReverseMap();
            CreateMap<Entities.Compounds, Entities.Compounds>().ForMember(dest => dest.Id, opt => opt.Ignore());
            #endregion

            #region Expense Profiles
            CreateMap<Entities.Expense, Dto.Expense.ExpenceCreateDto>().ReverseMap();
            CreateMap<Entities.Expense, Dto.Expense.ExpenseGetDto>().ReverseMap();
            CreateMap<Entities.Expense, Entities.Expense>()
              .ForMember(dest => dest.Id, opt => opt.Ignore());
            #endregion

            #region FinancialPeriod Profiles
            CreateMap<Entities.FinancialPeriod, Dto.FinancialPeriod.FinancialPeriodCreateDto>().ReverseMap();
            CreateMap<Entities.FinancialPeriod, Dto.FinancialPeriod.FinancialPeriodGetDto>().ReverseMap();
            CreateMap<Entities.FinancialPeriod, Entities.FinancialPeriod>().ForMember(dest => dest.Id, opt => opt.Ignore());
            #endregion

            #region Person Profiles
            CreateMap<Persons, PersonDto>().ReverseMap();
            CreateMap<Persons, UserRegisterDto>().ReverseMap();
            #endregion

            #region Resident Profiles
            CreateMap<Dto.Residents.ResidentCreateDto, Entities.ResidentEntity>().ReverseMap();
            CreateMap<Dto.Residents.ResidentGetDto, Entities.ResidentEntity>().ReverseMap();
            CreateMap<Entities.ResidentEntity, Entities.ResidentEntity>()
              .ForMember(dest => dest.Id, opt => opt.Ignore());
            #endregion

            #region UnitOwner Profiles
            CreateMap<CreateUnitOwnerDto, UnitOwner>().ReverseMap();
            CreateMap<GetUnitOwnerDto, UnitOwner>().ReverseMap();
            #endregion

            #region Unit Profiles
            CreateMap<UnitCreateDto, UnitEntity>().ReverseMap();
            CreateMap<UnitGetDto, UnitEntity>().ReverseMap();
            #endregion
        }
    }
}
