namespace Unit_Tests.DecouplingPatterns.TestDataBuilder;

public class BankInformationBuilder
{
    private string _bankName; 
    private string _iban;
    public BankInformationBuilder() 
    {
        _bankName = "ING";
        _iban = "BE68844010370034";
    }
    
    public BankInformationBuilder WithBankName(string bankName) 
    {
        _bankName = bankName;
        return this; 
    }
    
    public BankInformationBuilder WithIBAN(string iban) 
    {
        _iban = iban;
        return this; 
    }
    
    public BankInformation Build() 
    {
        return new BankInformation(_bankName, _iban); 
    }
    
    public static implicit operator BankInformation( BankInformationBuilder builder)
    {
        return builder.Build();
    }
}