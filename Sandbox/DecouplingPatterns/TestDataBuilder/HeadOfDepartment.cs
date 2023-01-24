public class HeadOfDepartment : ICanApproveExpenses {
    
    private const decimal MaximumAmountToApprove = 1000m; 
    public Guid Id { get; }
    
    public HeadOfDepartment(Guid id) 
    {
        Id = id; 
    }

    public bool CanApprove(decimal amountToApprove)
    {
        return amountToApprove <= MaximumAmountToApprove;
    }
}