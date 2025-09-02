using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuldingManager.Entities;

public class Persons
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    
    public string Mobile { get; set; }

    public Users User { get; set; }
    
    // navigation property
    public ICollection<UnitOwner> UnitOwners { get; set; }
}