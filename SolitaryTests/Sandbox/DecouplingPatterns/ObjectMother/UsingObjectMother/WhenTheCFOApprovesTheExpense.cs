namespace Unit_Tests.DecouplingPatterns.ObjectMother.UsingObjectMother;

[TestFixture]
public class When_the_chief_financial_officer_approves_an_expense_sheet_with_a_large_total_amount
{
    
    [SetUp]
    public void Context()
    {
        _approver = ApproverExamples.ChiefFinancialOfficer();
        _expenseSheet = ExpenseSheetExamples.ExpenseSheetWithASingleLargeExpense();

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