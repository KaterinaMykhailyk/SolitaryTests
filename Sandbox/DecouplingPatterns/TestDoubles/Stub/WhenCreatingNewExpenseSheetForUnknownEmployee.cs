using Unit_Tests.DecouplingPatterns.TestDoubles.Dummy;

namespace Unit_Tests.DecouplingPatterns.TestDoubles.Stub;

[TestFixture]
public class When_creating_a_new_expense_sheet_for_an_unknown_employee
{
    
[SetUp]
public void Context() 
{
    Employee unknownEmployee = null;
    var stubEmployeeRepository = new StubEmployeeRepository(unknownEmployee);
    var dummyExpenseSheetRepository = new DummyExpenseSheetRepository();
    _sut = new CreateExpenseSheetHandler(stubEmployeeRepository, dummyExpenseSheetRepository);
    
    var command = new CreateExpenseSheet(Guid.NewGuid(), Guid.NewGuid(), new DateTime(2018, 11, 11));
    _result = _sut.Handle(command);
}

[Test]
    public void Then_the_operation_should_fail() 
    {
        Assert.That(_result.IsSuccessful, Is.False); 
    }

private CreateExpenseSheetHandler _sut;
private Result _result; 
}