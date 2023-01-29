using Unit_Tests.DecouplingPatterns.TestDoubles;
using Unit_Tests.DecouplingPatterns.TestDoubles.Dummy;

[TestFixture]
public class When_creating_a_new_expense_sheet_using_a_non_existent_command
{
    
[SetUp]
public void Context() 
{
    var dummyEmployeeRepository = new DummyEmployeeRepository();
    var dummyExpenseSheetRepository = new DummyExpenseSheetRepository();
    _sut = new CreateExpenseSheetHandler(dummyEmployeeRepository, dummyExpenseSheetRepository);
    
    _createExpenseSheet = () => _sut.Handle(null);
}

[Test]
public void Then_an_exception_should_be_thrown() 
{ 
    Assert.That(_createExpenseSheet, Throws.ArgumentNullException);
} 

private CreateExpenseSheetHandler _sut;
private TestDelegate _createExpenseSheet; 
}
