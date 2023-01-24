namespace Unit_Tests.DecouplingPatterns.TestDataBuilder;

public class AddressBuilder
{
    private string _streetName;
    private string _houseNumber;
    private string _postalCode;
    private string _city;
    public AddressBuilder() 
    {
        _streetName = "Spooner Street";
        _houseNumber = "31";
        _postalCode = "2060ABC";
        _city = "Quahog";
    }
    
    public AddressBuilder WithStreetName(string streetName) 
    {
        _streetName = streetName;
        return this; 
    }
    
    public AddressBuilder WithHouseNumber(string houseNumber) 
    {
        _houseNumber = houseNumber;
        return this; 
    }
    
    public AddressBuilder WithPostalCode(string postalCode) 
    {
        _postalCode = postalCode;
        return this; 
    }
    
    public AddressBuilder WithCity(string city) 
    {
        _city = city;
        return this; 
    }
    
    public Address Build() 
    { 
        return new Address(_streetName, _houseNumber, _postalCode, _city); 
    } 
    
    public static implicit operator Address(AddressBuilder builder) 
    { 
        return builder.Build(); 
    }
}