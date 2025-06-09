public class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.ToUpper() == "USA" || country.ToUpper() == "UNITED STATES";
    }

    public string GetAddressString()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}