namespace Unit_Tests.DecouplingPatterns.ObjectMother.UsingObjectMother;

[TestFixture]
public class When_calculating_the_total_of_an_expense_sheet 
{
    
    [SetUp]
    public void Context() 
    {
        _expemseSheet = ExpenseSheetExamples.ExpenseSheetWithTwoSmallExpenses();
        
        _result = _expemseSheet.CalculateTotal();
    }

    [Test]
    public void Then_the_total_amount_of_all_expenses_on_the_sheet_should_be_returned()
    {
        Assert.That(_result, Is.EqualTo(79.56m));
    }
    
    private decimal _result;
    private ExpenseSheet _expemseSheet; 
}
