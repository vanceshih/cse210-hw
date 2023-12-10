using System;
using System.Collections.Generic;

class Order
{
    public List<Product> Products { get; set; } = new List<Product>();
    public Customer Customer { get; set; }

    public Order(Customer customer, List<Product> products)
    {
        Customer = customer;
        Products = products;
    }

    // Method to calculate the total cost of the order
    public double CalculateTotalCost()
    {
        double totalCost = Products.Sum(product => product.CalculateTotalPrice());
        totalCost += Customer.LivesInUSA() ? 5 : 35; // Shipping cost

        return totalCost;
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        return string.Join("\n", Products.Select(product => $"{product.Name} - {product.ProductId}"));
    }

    // Method to get the shipping label
    public string GetShippingLabel()
    {
        return $"Customer: {Customer.Name}\nAddress:\n{Customer.CustomerAddress.GetFullAddress()}";
    }
}
