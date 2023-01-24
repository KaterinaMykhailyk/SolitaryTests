public class Expense 
{
    public decimal Amount { get; } 
    public DateTime Date { get; } 
    public string Description { get; }
    public Expense(decimal amount, DateTime date, string description)
    {
        Amount = amount;
        Date = date;
        Description = description;
    } 
}