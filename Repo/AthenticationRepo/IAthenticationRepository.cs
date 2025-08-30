using BuldingManager.Dto;

namespace BuldingManager.Repo.AthenticationRepo;

public interface IAthenticationRepository
{
    Task<string> RegisterAsync(UserRegisterDto user);
    Task<string> LoginAsync(string username, string password);
}