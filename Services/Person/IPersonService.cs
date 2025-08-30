using BuldingManager.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BuldingManager.Services.Person;

public interface IPersonService
{
    public Task<IEnumerable<PersonDto>> GetPersons();
    public Task<PersonDto> GetPerson(int id);
    public Task CreatePerson(PersonDto person);
    public Task UpdatePerson(int id,PersonDto person);
    public Task DeletePerson(int id);
}