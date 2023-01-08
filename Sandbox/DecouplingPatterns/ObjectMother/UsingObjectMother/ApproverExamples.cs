namespace Unit_Tests.DecouplingPatterns.ObjectMother.UsingObjectMother;

public static class ApproverExamples {
    
    public static HeadOfDepartment HeadOfDepartment() 
    {
        return new HeadOfDepartment(Guid.NewGuid()); 
    }
    
    public static ChiefFinancialOfficer ChiefFinancialOfficer() 
    {
        return new ChiefFinancialOfficer(Guid.NewGuid()); 
    }
}