using BuldingManager.Dto;
using BuldingManager.Repo.PersonRepo;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BuldingManager.Services.Person;

public class PersonService:IPersonService
{
    private readonly IPersonRepository _repository;
    
    public PersonService(IPersonRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<PersonDto>> GetPersons()
    {
        var persons = await _repository.GetAllAsync();
        return persons;
    }

    public async Task<PersonDto> GetPerson(int id)
    {
        var Person = await _repository.GetByIdAsync(id);
        return Person;  
    }

    public async Task CreatePerson(PersonDto person)
    {
       await _repository.CreateAsync(person);
    }

    public async Task UpdatePerson(int id, PersonDto person)
    {
       await _repository.UpdateAsync(id, person);
    }

    public async Task DeletePerson(int id)
    {
        await _repository.DeleteAsync(id);
    }
}