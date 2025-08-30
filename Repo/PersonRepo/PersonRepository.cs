using AutoMapper;
using BuldingManager.ApplicationDbContext;
using BuldingManager.Dto;
using BuldingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuldingManager.Repo.PersonRepo;

public class PersonRepository:IPersonRepository {
    
    private readonly BuildingDbContext  _context;
    private readonly IMapper _mapper;

    public PersonRepository(BuildingDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<PersonDto>> GetAllAsync()
    {
        var persons = await _context.Persons.ToListAsync();
        return  _mapper.Map<IEnumerable<PersonDto>>(persons);
    }

    public async Task<PersonDto> GetByIdAsync(int id)
    {
        var person = await _context.Persons.FindAsync(id);
        return _mapper.Map<PersonDto>(person);
    }

    public async Task CreateAsync(PersonDto person)
    {
        Console.WriteLine("farhang");
        var personEntity = _mapper.Map<Persons>(person);
        _context.Persons.Add(personEntity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync( int id,PersonDto person)
    {
        var personEntity = await GetByIdAsync(id);

        if (personEntity == null)
        {
            throw new KeyNotFoundException($"Person with id {id} not found");
        }
        _mapper.Map(person, personEntity);
        
        _context.Entry(personEntity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var person = await _context.Persons.FindAsync(id);
        if (person != null)
        {
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}