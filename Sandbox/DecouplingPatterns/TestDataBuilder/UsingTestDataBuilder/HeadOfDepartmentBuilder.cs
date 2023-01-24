namespace Unit_Tests.DecouplingPatterns.TestDataBuilder;

public class HeadOfDepartmentBuilder
{
    private Guid _id;
    public HeadOfDepartmentBuilder() 
    {
        _id = Guid.NewGuid();
    }
    
    public HeadOfDepartmentBuilder WithId(Guid id) 
    {
        _id = id;
        return this; 
    }
    
    public HeadOfDepartment Build() 
    {
        return new HeadOfDepartment(_id); 
    }
    
    public static implicit operator HeadOfDepartment(HeadOfDepartmentBuilder builder)
    {
        
        return builder.Build(); 
    }
}