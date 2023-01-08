namespace Unit_Tests.DecouplingPatterns.ObjectMother;

public class ExpenseSheet {
    
    private readonly IList<DomainViolation> _violations; 
    
    private readonly IList<Expense> _expenses;
    public Guid Id { get; }
    public Guid EmployeeId { get; }
    
    public IEnumerable<Expense> Expenses => _expenses;
    public DateTime SubmissionDate { get; }
    public ExpenseSheetStatus Status { get; private set; } 
    
    public int Version { get; set; }

    public IEnumerable<DomainViolation> Violations => _violations;
    
    public ExpenseSheet(Guid id, Employee employee, DateTime submissionDate)
        : this(id, employee, submissionDate, Enumerable.Empty<Expense>())
    {}
    public ExpenseSheet(Guid id, Employee employee, DateTime submissionDate, IEnumerable<Expense> expenses)
    {
        Id = id;
        EmployeeId = employee.Id;
        SubmissionDate = submissionDate;
        _violations = new List<DomainViolation>();
        _expenses = new List<Expense>(expenses); 
    }
    
    public void AddExpense(decimal amount, DateTime date, string description)
    {
        var expense = new Expense(amount, date, description); 
        _expenses.Add(expense);
    }
    public decimal CalculateTotal() 
    {
        var totalAmount = _expenses.Select(expense => expense.Amount).Sum();
        return totalAmount; 
    }
    
    public void Approve(ICanApproveExpenses approver)
    {
        var totalAmount = CalculateTotal(); 
        if(!approver.CanApprove(totalAmount)) 
        {
            var violation = ExpenseSheetViolations.NotAllowedToApprove(totalAmount);
            _violations.Add(violation);
            return; 
        }
        Status = ExpenseSheetStatus.Approved;
    }
}