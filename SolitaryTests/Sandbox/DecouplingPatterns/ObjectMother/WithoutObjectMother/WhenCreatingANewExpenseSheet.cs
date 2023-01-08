using Unit_Tests.DecouplingPatterns.ObjectMother;

namespace Unit_Tests;

[TestFixture]
public class When_creating_a_new_expense_sheet
{
    [SetUp]
    public void Setup()
    {
        var address = new Address("Spooner Street", "31", "2060ABC", "Quahog");
        var bankInformation = new BankInformation("ING", "BE68844010370034");
        _employee = new Employee(Guid.NewGuid(), "Peter", "Griffin", address, bankInformation);
        _expenseSheet = new ExpenseSheet(
            new Guid("F0A6C1DD-AB38-4625-BFE4-1E8A7717CDDD"),
            _employee, 
            new DateTime(2018, 10, 31));
    }

    [Test]
    public void Then_it_should_have_an_identifier()
    {
        Assert.That(_expenseSheet.Id, Is.EqualTo(new Guid("F0A6C1DD-AB38-4625-BFE4-1E8A7717CDDD")));
    }
    
    [Test]
    public void Then_it_should_be_created_for_particular_employee()
    {
        Assert.That(_expenseSheet.EmployeeId, Is.EqualTo(_employee.Id));
    }
    
    [Test]
    public void Then_it_should_have_the_date_of_submission() {
        Assert.That(_expenseSheet.SubmissionDate, Is.EqualTo(new DateTime(2018, 10, 31)));
    }
    
    [Test]
    public void Then_it_should_have_the_status_requested() {
        Assert.That(_expenseSheet.Status, Is.EqualTo(ExpenseSheetStatus.Requested));
    }
    
    private Employee _employee;
    private ExpenseSheet _expenseSheet;
}