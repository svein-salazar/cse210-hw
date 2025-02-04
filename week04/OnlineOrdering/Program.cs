using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 11th St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Pollo", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P123", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P456", 25, 2));

        Address address2 = new Address("242 Peachtree St NW", "San Jose", "CA", "USA");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "P789", 45, 1));
        order2.AddProduct(new Product("Monitor", "P012", 300, 1));

        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
    }
}
