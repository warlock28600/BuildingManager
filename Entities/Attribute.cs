
using System.ComponentModel.DataAnnotations.Schema;

namespace BuldingManager.Entities
{
    public class Attribute:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttributeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int AttributeTypeId { get; set; }
        public AttributeType AttributeType{ get; set; }

        #region Navigation Properties
        public ICollection<Expense> Expenses { get; set; }
        #endregion
    }
}
