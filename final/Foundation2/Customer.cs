using System;
using System.Collections.Generic;

class Customer
{
    public string Name { get; set; }
    public Address CustomerAddress { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        CustomerAddress = address;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return CustomerAddress.IsInUSA();
    }
}
