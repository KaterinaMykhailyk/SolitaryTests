namespace Unit_Tests.DecouplingPatterns.TestDataBuilder;

public class EmployeeBuilder 
{
    private Guid _id;
    private string _firstName;
    private string _lastName;
    private AddressBuilder _address;
    private BankInformationBuilder _bankInformation;
    public EmployeeBuilder() 
    {
        _id = Guid.NewGuid();
        _firstName = "Peter";
        _lastName = "Griffin";
        _address = Example.Address();
        _bankInformation = Example.BankInformation();
    }
    
    public EmployeeBuilder WithId(Guid id) 
    {
        _id = id;
        return this; 
    }
    
    public EmployeeBuilder WithFirstName(string firstName) 
    {
        _firstName = firstName;
        return this; 
    }
    
    public EmployeeBuilder WithLastName(string lastName) 
    {
        _lastName = lastName;
        return this; 
    }
    
    public EmployeeBuilder WithAddress(Action<AddressBuilder> build)
    {
        build(_address); return this;
    }
    
    public EmployeeBuilder WithBankInformation(Action<BankInformationBuilder> build)
    {
        build(_bankInformation); return this;
    }
    public Employee Build() 
    {
        return new Employee(_id, _firstName, _lastName, _address, _bankInformation);
    }
    
    public static implicit operator Employee(EmployeeBuilder builder)
    {
        return builder.Build();
    } 
}