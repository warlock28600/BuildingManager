using BuldingManager.Dto;
using BuldingManager.Repo.AthenticationRepo;
using BuldingManager.Repo.PersonRepo;

namespace BuldingManager.Services.Athentication;

public class AthenticationService : IAthenticationService
{
    private readonly IAthenticationRepository _repository;

    public AthenticationService(IAthenticationRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<TokenDto> RegisterAsync(UserRegisterDto userDto)
    {
        return await _repository.RegisterAsync(userDto);
    }

    public async Task<TokenDto> LoginAsync(LoginDto loginDto)
    {
        return await _repository.LoginAsync(loginDto);
    }
}