using BuldingManager.Dto;

namespace BuldingManager.Services.Athentication;

public interface IAthenticationService
{
    Task<TokenDto> RegisterAsync(UserRegisterDto userDto);
    Task<TokenDto> LoginAsync(LoginDto loginDto);
}