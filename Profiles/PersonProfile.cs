using AutoMapper;
using BuldingManager.Dto;
using BuldingManager.Entities;

namespace BuldingManager.Profiles;

public class PersonProfile:Profile
{
    public PersonProfile()
    {
        CreateMap<Persons, PersonDto>().ReverseMap();
        CreateMap<Persons, UserRegisterDto>().ReverseMap();
        
    }

}