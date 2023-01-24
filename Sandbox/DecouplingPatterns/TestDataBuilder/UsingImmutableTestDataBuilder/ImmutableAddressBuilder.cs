namespace Unit_Tests.DecouplingPatterns.TestDataBuilder.UsingImmutableTestDataBuilder;

public class ImmutableAddressBuilder {
    private string _streetName; 
    private string _houseNumber; 
    private string _postalCode; 
    private string _city;
    
    public ImmutableAddressBuilder() : this("Spooner Street", "31", "2060ABC", "Quahog")
    {}
    private ImmutableAddressBuilder(string streetName, string houseNumber, string postalCode, string city)
    {
        _streetName = streetName;
        _houseNumber = houseNumber;
        _postalCode = postalCode;
        _city = city;
    }
    
    public ImmutableAddressBuilder WithStreetName(string streetName)
    {
        _streetName = streetName;
        return new ImmutableAddressBuilder(streetName, _houseNumber, _postalCode, _city);
    }
    public ImmutableAddressBuilder WithHouseNumber(string houseNumber)
    {
        _houseNumber = houseNumber;
        return new ImmutableAddressBuilder(_streetName, houseNumber, _postalCode, _city);
    }
    
    public ImmutableAddressBuilder WithPostalCode( string postalCode)
    {
        _postalCode = postalCode;
        return new ImmutableAddressBuilder(_streetName, _houseNumber, postalCode, _city);
    }
    
    public ImmutableAddressBuilder WithCity(string city) {
        _city = city;
        return new ImmutableAddressBuilder(_streetName, _houseNumber, _postalCode, city);
    }
    public Address Build() {
        return new Address(_streetName, _houseNumber, _postalCode, _city);
    }
    
    public static implicit operator Address(ImmutableAddressBuilder builder)
    {
        return builder.Build();
    } 
}
    