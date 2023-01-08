using Unit_Tests.DecouplingPatterns.ObjectMother;

namespace Unit_Tests;

[TestFixture]
public class When_the_head_of_the_department_approves_an_expense_sheet_with_a_total_amount_that_is_allowed
{
    
    [SetUp]
    public void Context() {
        var address = new Address("Spooner Street", "31", "2060ABC", "Quahog");
        var bankInformation = new BankInformation("ING", "BE68844010370034");
        var employee = new Employee(Guid.NewGuid(), "Peter", "Griffin", address, bankInformation);
        _approver = new HeadOfDepartment(Guid.NewGuid());
        _expenseSheet = new ExpenseSheet(Guid.NewGuid(), employee, new DateTime(2018, 10, 31));
        _expenseSheet.AddExpense(123.88m, new DateTime(2018, 10, 12), "Plane ticket to and from Berlin");
        _expenseSheet.Approve(_approver);
    }

    [Test]
    public void Then_the_status_should_transition_to_approved() 
    { 
        Assert.That(_expenseSheet.Status, Is.EqualTo(ExpenseSheetStatus.Approved));
    }

    private HeadOfDepartment _approver;
    private ExpenseSheet _expenseSheet; 
}