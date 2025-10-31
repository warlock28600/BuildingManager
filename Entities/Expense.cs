using BuldingManager.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace BuldingManager.Entities
{
    public class Expense
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int FinancialPeriodId { get; set; }
        public int AttributeId { get; set; }

        public ExpanseType ExpanseType { get; set; }

        #region Navigation Properties
        public FinancialPeriod FinancialPeriod { get; set; }
        public Attribute Attribute { get; set; }
        #endregion
    }
}
