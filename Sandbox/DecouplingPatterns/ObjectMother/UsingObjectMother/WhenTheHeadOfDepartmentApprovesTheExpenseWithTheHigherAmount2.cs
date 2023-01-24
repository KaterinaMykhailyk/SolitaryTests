namespace Unit_Tests.DecouplingPatterns.ObjectMother.UsingObjectMother;

[TestFixture]
public class When_the_head_of_the_department_approves_an_expense_sheet_with_a_total_amount_that_is_higher_than_allowed2
{
    
    [SetUp]
    public void Context() 
    {
        _approver = ApproverExamples.HeadOfDepartment();
        _expenseSheet = ExpenseSheetExamples.ExpenseSheetWithASingleLargeExpense();
        
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
