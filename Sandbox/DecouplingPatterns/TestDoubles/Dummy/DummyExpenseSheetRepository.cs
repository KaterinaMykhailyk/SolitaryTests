namespace Unit_Tests.DecouplingPatterns.TestDoubles.Dummy;

public class DummyExpenseSheetRepository : IExpenseSheetRepository 
{
    public ExpenseSheet Get(Guid id) 
    {
        throw new NotImplementedException(
            "The Get method of the ExpenseSheetRepository " + "shouldn't get called.");
    }
    
    public void Save(ExpenseSheet expenseSheet) 
    {
        throw new NotImplementedException(
            "The Save method of the ExpenseSheetRepository " + "shouldn't get called.");
    } 
}