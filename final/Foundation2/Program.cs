using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create addresses
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var address2 = new Address("456 Park Ave", "Cityville", "NY", "USA");
        var address3 = new Address("789 Selma Rd", "Burnaby", "BC", "CANADA");

        // Create customers
        var customer1 = new Customer("John Doe", address1);
        var customer2 = new Customer("Jane Smith", address2);
        var customer3 = new Customer("Vance Shih", address3);

        // Create products
        var product1 = new Product("Laptop", "ABC123", 1190.00, 2);
        var product2 = new Product("Mouse", "DEF456", 29.85, 3);
        var product3 = new Product("Keyboard", "GHI789", 45.38, 1);

        // Create orders
        var order1 = new Order(customer1, new List<Product> { product1, product2 });
        var order2 = new Order(customer2, new List<Product> { product2, product3 });
        var order3 = new Order(customer3, new List<Product> { product2, product3 });

        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());

        Console.WriteLine("\nOrder 3:");
        Console.WriteLine("Packing Label:\n" + order3.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order3.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order3.CalculateTotalCost());
    }
}
