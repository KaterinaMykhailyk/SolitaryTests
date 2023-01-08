namespace Unit_Tests.DecouplingPatterns.ObjectMother.UsingObjectMother;

[TestFixture]
public class When_creating_a_new_expense_sheet {
    
    [SetUp]
    public void Of() 
    {
        _expenseSheet = ExpenseSheetExamples.ExpenseSheetWithoutExpenses();
    }
    
    [Test]
    public void Then_it_should_have_an_identifier() 
    {
        Assert.That(_expenseSheet.Id, Is.EqualTo(new Guid("F0A6C1DD-AB38-4625-BFE4-1E8A7717CDDD")));
    }
    
    [Test]
    public void Then_it_should_be_created_for_particular_employee()
    {
        Assert.That(_expenseSheet.EmployeeId, Is.EqualTo(new Guid("9822E457-D608-4307-AB6E-C253466F57CD")));
    }
    
    [Test]
    public void Then_it_should_have_the_date_of_submission() 
    {
        Assert.That(_expenseSheet.SubmissionDate, Is.EqualTo(new DateTime(2018, 10, 31)));
    }
    
    [Test]
    public void Then_it_should_have_the_status_requested() 
    {
        Assert.That(_expenseSheet.Status, Is.EqualTo(ExpenseSheetStatus.Requested));
    }
    
    private ExpenseSheet _expenseSheet; 
}
    