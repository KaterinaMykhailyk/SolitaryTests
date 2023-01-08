namespace Unit_Tests.DecouplingPatterns.ObjectMother;
public class Address
{ 
    public string StreetName { get; } 
    public string HouseNumber { get; } 
    public string PostalCode { get; }
    public string City { get; } 
    
    public Address(string streetName, string houseNumber, string postalCode, string city) 
    {
            StreetName = streetName;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
            City = city; 
    }
}
