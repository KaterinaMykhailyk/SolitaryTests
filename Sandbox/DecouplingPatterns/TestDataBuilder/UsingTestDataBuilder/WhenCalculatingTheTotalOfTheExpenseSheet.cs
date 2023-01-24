using Unit_Tests.DecouplingPatterns.TestDataBuilder;

[TestFixture]
public class When_calculating_the_total_of_an_expense_sheet 
{
    
    [SetUp]
    public void Context() 
    {
        _expenseSheet = Example.ExpenseSheet()
            .WithExpense(66.57m, new DateTime(2018, 10, 01), "Lunch at Giovanni's")
            .WithExpense(12.99m, new DateTime(2018, 10, 05), "Awesome paperclips");
        _result = _expenseSheet.CalculateTotal();
    }
    
    [Test]
    public void Then_the_total_amount_of_all_expenses_on_the_sheet_should_be_returned()
    {
        Assert.That(_result, Is.EqualTo(79.56m));
    }
    
    private decimal _result;
    private ExpenseSheet _expenseSheet; 
}
