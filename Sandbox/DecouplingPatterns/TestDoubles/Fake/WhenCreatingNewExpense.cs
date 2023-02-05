namespace Unit_Tests.DecouplingPatterns.TestDoubles.Fake;

[TestFixture]
public class When_creating_a_new_expense_sheet 
{
    [SetUp]
    public void Context() 
    {
        var employee = Example.Employee().WithId(new Guid("680D0C0A-E445-4344-B67A-363589E2746A"));
        var stubEmployeeRepository = new StubEmployeeRepository(employee);
        _fakeExpenseSheetRepository = new FakeExpenseSheetRepository();
        _sut = new CreateExpenseSheetHandler(stubEmployeeRepository, _fakeExpenseSheetRepository);
        
        var command = new CreateExpenseSheet(
            new Guid("4048A482-1CBA-45AA-8709-6409B9FD32E3"), new Guid("680D0C0A-E445-4344-B67A-363589E2746A"), new DateTime(2018, 11, 11));
        _result = _sut.Handle(command);
    }
   
    [Test]
    public void Then_the_operation_should_succeed() 
    {
        Assert.That(_result.IsSuccessful);
    }
    
    private FakeExpenseSheetRepository _fakeExpenseSheetRepository;
    private CreateExpenseSheetHandler _sut;
    private Result _result; 
}