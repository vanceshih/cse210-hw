using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public string ProductId { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    // Method to calculate the total price for the product
    public double CalculateTotalPrice()
    {
        return Price * Quantity;
    }
}
