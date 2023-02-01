namespace Unit_Tests.DecouplingPatterns.TestDoubles.Spy;

public class SpyExpenseSheetRepository : IExpenseSheetRepository 
{
    private readonly ExpenseSheet _result;
    public ExpenseSheet SavedExpenseSheet { get; private set; }
    
    public SpyExpenseSheetRepository(ExpenseSheet result) 
    {
        _result = result;
    }
    
    public ExpenseSheet Get(Guid id)
    {
        return _result; 
    }
    
    public void Save(ExpenseSheet expenseSheet) 
    {
        SavedExpenseSheet = expenseSheet;
    }
}
