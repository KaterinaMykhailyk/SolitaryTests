namespace Unit_Tests.DecouplingPatterns.ObjectMother;

public class BankInformation
{
    public string BankName { get; } 
    public string IBAN { get; } 
    
    public BankInformation(string bankName, string iban) 
    {
            BankName = bankName;
            IBAN = iban; 
    }
}