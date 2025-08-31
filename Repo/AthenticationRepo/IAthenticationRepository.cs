using BuldingManager.Dto;

namespace BuldingManager.Repo.AthenticationRepo;

public interface IAthenticationRepository
{
    Task<TokenDto> RegisterAsync(UserRegisterDto user);
    Task<TokenDto> LoginAsync(LoginDto loginDto);
}