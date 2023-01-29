namespace Unit_Tests.DecouplingPatterns.TestDoubles;
public class CreateExpenseSheet 
{
    public Guid Id { get; }
    public Guid EmployeeId { get; }
    public DateTime SubmissionDate { get; }
    public CreateExpenseSheet(Guid id, Guid employeeId, DateTime submissionDate)
    {
        Id = id;
        EmployeeId = employeeId;
        SubmissionDate = submissionDate;
    }
}