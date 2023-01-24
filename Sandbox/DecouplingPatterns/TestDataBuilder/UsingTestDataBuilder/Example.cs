namespace Unit_Tests.DecouplingPatterns.TestDataBuilder;

public class Example
{
        public static ExpenseSheetBuilder ExpenseSheet() 
                => new ExpenseSheetBuilder();
        public static AddressBuilder Address() 
                => new AddressBuilder();
        public static BankInformationBuilder BankInformation() 
                => new BankInformationBuilder();
        public static EmployeeBuilder Employee() 
                => new EmployeeBuilder();
        public static HeadOfDepartmentBuilder HeadOfDepartment()
                => new HeadOfDepartmentBuilder();
        public static ChiefFinancialOfficerBuilder ChiefFinancialOfficer()
                => new ChiefFinancialOfficerBuilder();
}