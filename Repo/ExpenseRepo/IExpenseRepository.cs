namespace BuldingManager.Repo.ExpenseRepo
{
    public interface IExpenseRepository
    {
        public Task<IEnumerable<Entities.Expense>> GetExpensesAsync();
        public Task<Entities.Expense?> GetExpenseByIdAsync(int id);
        public Task<bool> CreateExpenseAsync(Entities.Expense expense);
        public Task<bool> UpdateExpenseAsync(int id,Entities.Expense expense);
        public Task<bool> DeleteExpenseAsync(int id);
    }
}
