namespace Unit_Tests.DecouplingPatterns.TestDoubles.Fake;

public class FakeExpenseSheetRepository : IExpenseSheetRepository 
{
    private readonly Dictionary<Guid, ExpenseSheet> _expenseSheets;
    
    public FakeExpenseSheetRepository() 
    {
        _expenseSheets = new Dictionary<Guid, ExpenseSheet>(); 
    }
    public ExpenseSheet Get(Guid id) 
    {
        var isFound = _expenseSheets.TryGetValue(id, out var expenseSheet);
        
        return isFound ? expenseSheet : null; 
    }
    
    public void Save(ExpenseSheet expenseSheet) 
    {
        var current = Get(expenseSheet.Id);
        var currentVersion = current?.Version ?? 0;
        if (currentVersion != expenseSheet.Version) throw new OptimisticConcurrencyException<ExpenseSheet>(expenseSheet.Id, currentVersion, expenseSheet.Version);
        expenseSheet.Version += 1;
        _expenseSheets[expenseSheet.Id] = expenseSheet;
    }
}
    