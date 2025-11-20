using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Orders
        Address address1 = new Address("123 Dener St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Mark Britton", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "KB95", 50, 1));
        order1.AddProduct(new Product("Mouse", "MS100", 20, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Address address2 = new Address("45 Namirembe Road", "Kampala", "Central", "Uganda");
        Customer customer2 = new Customer("Andrew Mukasa", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop", "LP400", 1200, 1));
        order2.AddProduct(new Product("USB Cable", "USB25", 5, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}\n");
    }
}