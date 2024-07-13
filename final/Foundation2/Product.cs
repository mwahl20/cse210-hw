using System;
public class Product
{
    public string _product;
    public string _pID;
    public double _ppu;
    public int _quantity;

    public Product(string name, string productID, double ppu, int quantity)
    {
        _product = name;
        _pID = productID;
        _ppu = ppu;
        _quantity = quantity;
    }
    public double ComputeTotalPrice()
    {
        return _ppu*_quantity;
    }
}