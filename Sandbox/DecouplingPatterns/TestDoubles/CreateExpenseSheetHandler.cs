namespace Unit_Tests.DecouplingPatterns.TestDoubles;

public class CreateExpenseSheetHandler : ICommandHandler<CreateExpenseSheet>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IExpenseSheetRepository _expenseSheetRepository;
    
    public CreateExpenseSheetHandler(IEmployeeRepository employeeRepository, IExpenseSheetRepository expenseSheetRepository)
    {
        _employeeRepository = employeeRepository;
        _expenseSheetRepository = expenseSheetRepository;
    }
    
    public Result Handle(CreateExpenseSheet command) 
    {
        if (null == command) throw new ArgumentNullException(nameof(command));
        var employee = _employeeRepository.Get(command.EmployeeId);
        
        if (null == employee) 
        {
            var message = "The employee with identifier " + $"'{command.EmployeeId}' could not be found.";
            return Result.Failure(new DomainViolation(message)); 
        }
        var expenseSheet = new ExpenseSheet(command.Id, employee, command.SubmissionDate);
        _expenseSheetRepository.Save(expenseSheet);
        
        return Result.Success(); 
    }
}