using Unit_Tests.DecouplingPatterns.ObjectMother;

namespace Unit_Tests;

[TestFixture]
public class When_calculating_the_total_of_an_expense_sheet {
    
    [SetUp]
    public void SetUp() {
        var address = new Address("Spooner Street", "31", "2060ABC", "Quahog");
        var bankInformation = new BankInformation("ING", "BE68844010370034");
        var employee = new Employee(Guid.NewGuid(), "Peter", "Griffin", address, bankInformation);
        _expenseSheet = new ExpenseSheet(Guid.NewGuid(), employee, new DateTime(2018, 10, 31));
        
        _expenseSheet.AddExpense(66.57m, new DateTime(2018, 10, 01), "Lunch at Giovanni's");
        _expenseSheet.AddExpense(12.99m, new DateTime(2018, 10, 05), "Awesome paperclips");
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
