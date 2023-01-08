using Unit_Tests.DecouplingPatterns.ObjectMother;

namespace Unit_Tests;

[TestFixture]
public class When_the_head_of_the_department_approves_an_expense_sheet_with_a_total_amount_that_is_higher_than_allowed
{
    
    [SetUp]
    public void Context() 
    {
        _approver = new HeadOfDepartment(Guid.NewGuid());
        var address = new Address("Spooner Street", "31", "2060ABC", "Quahog");
        var bankInformation = new BankInformation("ING", "BE68844010370034");
        var employee = new Employee(Guid.NewGuid(), "Peter", "Griffin", address, bankInformation);
        _expenseSheet = new ExpenseSheet(Guid.NewGuid(), employee, new DateTime(2018, 10, 31));
        
        _expenseSheet.AddExpense(5684.24m, new DateTime(2018, 10, 24), "Exuberant party");
        _expenseSheet.Approve(_approver);
    }

    [Test]
    public void Then_this_should_result_in_a_domain_violation() 
    {
        Assert.That(_expenseSheet.Violations, Contains.Item(ExpenseSheetViolations.NotAllowedToApprove(5684.24m)));
    }

    [Test]
    public void Then_the_status_should_NOT_transition() 
    {
        Assert.That(_expenseSheet.Status, Is.EqualTo(ExpenseSheetStatus.Requested));
    }

    private HeadOfDepartment _approver;
    private ExpenseSheet _expenseSheet; 
}
