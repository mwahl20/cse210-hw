using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("120 W 2nd St", "Rexburg", "ID", "usa");
        Customer customer1 = new Customer("Michael w", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "B420", 1500.0, 1);
        Product product2 = new Product("Oculus Quest 2", "O124", 40.00, 1);
        Product product3 = new Product("Popcorn Chicken", "C140", 8.75, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine(order1.CreateShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice():0.00}");
    }
}