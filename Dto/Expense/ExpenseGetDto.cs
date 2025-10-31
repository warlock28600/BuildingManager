using BuldingManager.Domain;
using BuldingManager.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuldingManager.Dto.Expense
{
    public class ExpenseGetDto:BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int FinancialPeriodId { get; set; }
        public int AttributeId { get; set; }

        public ExpanseType ExpanseType { get; set; }
    }
}
