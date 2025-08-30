using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuldingManager.Entities;

public class Users
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }
    public int PersonId { get; set; }
    public string UserName { get; set; }
    public string  Password { get; set; }
    public string Role { get; set; } = "User";
    public Persons Person { get; set; }
}