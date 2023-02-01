namespace Unit_Tests.DecouplingPatterns.TestDoubles.Stub;

public class StubEmployeeRepository : IEmployeeRepository 
{
    private readonly Employee _result;
    
    public StubEmployeeRepository(Employee result) 
    {
        _result = result;
    }
    
    public Employee Get(Guid id) 
    {
        return _result; 
    }
}