public class ChiefFinancialOfficer : ICanApproveExpenses {
    public Guid Id { get; }
    
    public ChiefFinancialOfficer(Guid id) 
    {
        Id = id; 
    }
    public bool CanApprove(decimal amountToApprove) 
    {
        return true; 
    }
}