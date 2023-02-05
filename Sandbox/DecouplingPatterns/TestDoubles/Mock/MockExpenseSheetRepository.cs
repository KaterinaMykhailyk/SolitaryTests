namespace Unit_Tests.DecouplingPatterns.TestDoubles.Mock;

public class MockExpenseSheetRepository : IExpenseSheetRepository
{
    private readonly ExpenseSheet _result;
    private ExpenseSheet _expectedExpenseSheetToBeSaved;
    private ExpenseSheet _savedExpenseSheet;

    public MockExpenseSheetRepository (ExpenseSheet result)
    {
        _result = result;
    }

    public ExpenseSheet Get(Guid id)
    {
        return _result;
    }

    public void Save(ExpenseSheet expenseSheet)
    {
        _savedExpenseSheet = expenseSheet;
    }

    public void ExpectSaveToBeCalled(ExpenseSheet expenseSheetToBeSaved)
    {
        _expectedExpenseSheetToBeSaved = expenseSheetToBeSaved;
    }

    public void Verify()
    {
        if (null == _expectedExpenseSheetToBeSaved) return;
        
        Assert.That(_savedExpenseSheet, Is.Not.Null);
        Assert.That(_savedExpenseSheet.Id, Is.EqualTo(_expectedExpenseSheetToBeSaved.Id));
        Assert.That(_savedExpenseSheet.EmployeeId, Is.EqualTo(_expectedExpenseSheetToBeSaved.EmployeeId));
        Assert.That(_savedExpenseSheet.SubmissionDate, Is.EqualTo(_expectedExpenseSheetToBeSaved.SubmissionDate));
    }
}