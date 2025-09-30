using BuldingManager.Entities;

namespace BuldingManager.Dto;

public class UserDto
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public string UserName { get; set; }
    public string  Password { get; set; }
    public string Role { get; set; } = "User";
    public Persons Person { get; set; }
}