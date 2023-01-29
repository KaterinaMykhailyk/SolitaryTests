namespace Unit_Tests.DecouplingPatterns.TestDoubles.Dummy;

public class DummyEmployeeRepository : IEmployeeRepository 
{
    public Employee Get(Guid id) 
    {
        throw new NotImplementedException(
            "The Get method of the EmployeeRepository " + "shouldn't get called.");
    } 
}