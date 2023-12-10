using System;
using System.Collections.Generic;

class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    // Method to get a formatted string of the address
    public string GetFullAddress()
    {
        return $"{StreetAddress}\n{City}, {StateProvince}\n{Country}";
    }
}
