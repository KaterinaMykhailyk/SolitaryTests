namespace Unit_Tests.DecouplingPatterns.ObjectMother.UsingObjectMother;

[TestFixture]
public class When_the_head_of_the_department_approves_an_expense_sheet_with_a_total_amount_that_is_allowed2
{
    
    [SetUp]
    public void Context() 
    {
        _approver = ApproverExamples.HeadOfDepartment();
        _expenseSheet = ExpenseSheetExamples.ExpenseSheetWithASingleModerateExpense();
        
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