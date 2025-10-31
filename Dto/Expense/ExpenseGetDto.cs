using BuldingManager.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuldingManager.Dto.Expense
{
    public class ExpenseGetDto
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
