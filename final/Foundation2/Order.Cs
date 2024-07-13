using System;
using System.Text;
public class Order
{
    private List<Product> products;
    private Customer customer;
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach(var product in products)
        {
            totalPrice += product.ComputeTotalPrice();
        }
        return totalPrice+ AddShippingCost();
    }
    public double AddShippingCost()
    {
        if(customer.Address._country == "usa")
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public string CreatePackingLabel()
    {
        StringBuilder packinglabel = new StringBuilder();
        packinglabel.AppendLine("PackingLabel:");
        foreach(var product in products)
        {
            packinglabel.AppendLine($"Product Name: {product._product}, Product ID: {product._pID}");

        }
        return packinglabel.ToString();
    }
    public string CreateShippingLabel()
    {
        StringBuilder shippinglabel = new StringBuilder();
        shippinglabel.AppendLine($"Shipping Label: ");
        shippinglabel.AppendLine($"Name: {customer._name}");
        shippinglabel.AppendLine($"Address: {customer.Address._streetnumber}");
        shippinglabel.AppendLine($"City: {customer.Address._city}, {customer.Address._state}");
        shippinglabel.AppendLine($"Country: {customer.Address._country}");
        return shippinglabel.ToString();
    }
}