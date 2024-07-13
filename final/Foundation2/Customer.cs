using System;
using System.Net.Sockets;
public class Customer
{
    public string _name;
    public Address Address;
    public Customer(string name, Address address)
    {
        _name = name;
        Address = address;
    }
}