namespace Unit_Tests.DecouplingPatterns.ObjectMother;

public class Employee
{
    public Guid Id { get; }
    public string FirstName { get; } 
    public string LastName { get; } 
    public Address Address { get; }
    public BankInformation BankInformation { get; }
    
    public Employee(Guid id, string firstName, string lastName, Address address, BankInformation bankInformation) 
    {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            BankInformation = bankInformation;
    } 
}