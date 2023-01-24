namespace Unit_Tests.DecouplingPatterns.TestDataBuilder;

public class ExpenseSheetBuilder 
{
    private Guid _id;
    private EmployeeBuilder _employee; 
    private DateTime _submissionDate; 
    private List<Expense> _expenses;
    
    public ExpenseSheetBuilder() 
    {
        _id = Guid.NewGuid();
        _employee = Example.Employee(); 
        _submissionDate = new DateTime(2018, 10, 01); 
        _expenses = new List<Expense>();
    }
    
    public ExpenseSheetBuilder WithId(Guid id) 
    {
        _id = id;
        return this; 
    }
    
    public ExpenseSheetBuilder WithEmployee(Action<EmployeeBuilder> build)
    {
        build(_employee); 
        return this;
    }
    
    public ExpenseSheetBuilder WithEmployee(EmployeeBuilder employeeBuilder)
    {
        _employee = employeeBuilder; 
        return this;
    }
    
    public ExpenseSheetBuilder WithSubmissionDate(DateTime submissionDate)
    {
        _submissionDate = submissionDate; 
        return this;
    }

    public ExpenseSheetBuilder WithExpense(decimal amount, DateTime date, string description)
    {
        var expense = new Expense(amount, date, description); 
        _expenses.Add(expense);
        return this;
    }
    
    public ExpenseSheet Build() {
        return new ExpenseSheet(_id, _employee, _submissionDate, _expenses);
    }
    
    public static implicit operator ExpenseSheet(ExpenseSheetBuilder builder)
    {
        return builder.Build();
    } 
}

