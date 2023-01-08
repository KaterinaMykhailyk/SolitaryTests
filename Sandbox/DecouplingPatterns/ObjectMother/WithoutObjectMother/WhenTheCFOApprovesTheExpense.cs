using Unit_Tests.DecouplingPatterns.ObjectMother;

namespace Unit_Tests;

[TestFixture]
public class When_the_chief_financial_controller_approves_an_expense_sheet_with_a_large_total_amount
{

    [SetUp]
    public void Context()
    {
        _approver = new ChiefFinancialOfficer(Guid.NewGuid());
        var address = new Address("Spooner Street", "31", "2060ABC", "Quahog");
        var bankInformation = new BankInformation("ING", "BE68844010370034");
        var employee = new Employee(Guid.NewGuid(), "Peter", "Griffin", address, bankInformation);

        _expenseSheet = new ExpenseSheet(Guid.NewGuid(), employee, new DateTime(2018, 10, 31));
        _expenseSheet.AddExpense(5684.24m, new DateTime(2018, 10, 24), "Exuberant party");
        _expenseSheet.Approve(_approver);
    }
    
    [Test]
    public void Then_the_status_should_transition_to_approved() 
    {
        Assert.That(_expenseSheet.Status, Is.EqualTo(ExpenseSheetStatus.Approved));
    }


    private ChiefFinancialOfficer _approver;
    private ExpenseSheet _expenseSheet;
}
