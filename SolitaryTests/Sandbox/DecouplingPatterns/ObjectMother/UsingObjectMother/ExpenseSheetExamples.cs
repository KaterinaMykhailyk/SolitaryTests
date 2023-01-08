namespace Unit_Tests.DecouplingPatterns.ObjectMother.UsingObjectMother;

public static class ExpenseSheetExamples
{
    public static ExpenseSheet ExpenseSheetWithoutExpenses()
    {
        var employee = EmployeeExamples.AverageEmployee();
        var expenseSheet = new ExpenseSheet(
            new Guid("F0A6C1DD-AB38-4625-BFE4-1E8A7717CDDD"), 
            employee,
            new DateTime(2018, 10, 31));
        
        return expenseSheet;
    }

    public static ExpenseSheet ExpenseSheetWithTwoSmallExpenses()
    {
        var employee = EmployeeExamples.AverageEmployee();
        var expenseSheet = new ExpenseSheet(Guid.NewGuid(), employee, new DateTime(2018, 10, 31));
        expenseSheet.AddExpense(66.57m,
            new DateTime(2018, 10, 01), "Lunch at Giovanni's");
        expenseSheet.AddExpense(12.99m,
            new DateTime(2018, 10, 05), "Awesome paperclips");
        
        return expenseSheet;
    }

    public static ExpenseSheet ExpenseSheetWithASingleModerateExpense()
    {
        var employee = EmployeeExamples.AverageEmployee();
        var expenseSheet = new ExpenseSheet(Guid.NewGuid(), employee, new DateTime(2018, 10, 31));
        expenseSheet.AddExpense(123.88m,
            new DateTime(2018, 10, 12),
            "Plane ticket to and from Berlin");
        
        return expenseSheet;
    }

    public static ExpenseSheet ExpenseSheetWithASingleLargeExpense()
    {
        var employee = EmployeeExamples.AverageEmployee();
        var expenseSheet = new ExpenseSheet(Guid.NewGuid(),
            employee, new DateTime(2018, 10, 31));
        expenseSheet.AddExpense(5684.24m,
            new DateTime(2018, 10, 24), "Exuberant party");
        
        return expenseSheet;
    }
}
        
        