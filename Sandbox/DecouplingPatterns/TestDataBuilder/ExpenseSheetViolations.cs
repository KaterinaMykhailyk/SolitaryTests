public class ExpenseSheetViolations 
{
    public static DomainViolation NotAllowedToApprove(decimal amountToApprove)
    {
        var message = "The specified approver is not allowed " +
                      "to approve an expense sheet with a total amount " +
                      $"of {amountToApprove} Euro."; 
        
        return new DomainViolation(message);
    } 
}