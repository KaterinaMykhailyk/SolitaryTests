namespace Unit_Tests.DecouplingPatterns.ObjectMother;

public struct DomainViolation 
{
    public string Message { get; }
    public DomainViolation(string message) 
    {
        Message = message;
    }
}