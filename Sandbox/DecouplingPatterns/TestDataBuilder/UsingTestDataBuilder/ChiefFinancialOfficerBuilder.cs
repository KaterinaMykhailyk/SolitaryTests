namespace Unit_Tests.DecouplingPatterns.TestDataBuilder;

public class ChiefFinancialOfficerBuilder
{
    private Guid _id;
    public ChiefFinancialOfficerBuilder() 
    {
        _id = Guid.NewGuid();
    }
    
    public ChiefFinancialOfficerBuilder WithId(Guid id) 
    {
        _id = id;
        return this; 
    }
    public ChiefFinancialOfficer Build() 
    {
        return new ChiefFinancialOfficer(_id); 
    }
    
    public static implicit operator ChiefFinancialOfficer(ChiefFinancialOfficerBuilder builder)
    {
        return builder.Build();
    }
}