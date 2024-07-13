public class Address
{
    public string _streetnumber;
    public string _city;
    public string _state;
    public string _country;
    public Address(string streetaddress,string city, string state, string country)
    {
        _streetnumber = streetaddress;
        _city = city;
        _state = state;
        _country = country;
    }
}