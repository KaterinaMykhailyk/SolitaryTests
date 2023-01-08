namespace Unit_Tests.DecouplingPatterns.ObjectMother.UsingObjectMother;

public static class EmployeeExamples {
    public static Employee AverageEmployee() 
    { 
        var address = new Address("Spooner Street", "31", "2060ABC", "Quahog"); 
        var bankInformation = new BankInformation("ING", "BE68844010370034"); 
        
        return new Employee(
            new Guid(
                "9822E457-D608-4307-AB6E-C253466F57CD"), 
            "Peter", 
            "Griffin", 
            address, 
            bankInformation); 
    } 
}