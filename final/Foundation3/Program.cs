using System;

class Program
{
    static void Main()
    {
        // Create addresses
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var address2 = new Address("456 Park Ave", "Cityville", "NY", "USA");
        var address3 = new Address("789 Grand Dr", "Forest Park", "GA", "USA");

        // Create events of each type
        var lectureEvent = new Lecture("Lectures", "Tech Talk", "Exciting tech advancements", DateTime.Now.AddDays(7), new TimeSpan(14, 0, 0), address1, "John Doe", 50);
        var receptionEvent = new Reception("Receptions", "Networking Night", "Connect and network with professionals", DateTime.Now.AddDays(14), new TimeSpan(18, 30, 0), address2, "rsvp@gmail.com");
        var outdoorEvent = new OutdoorGathering("Outdoor gatherings", "Fire Camp", "Enjoy fun activities", DateTime.Now.AddDays(21), new TimeSpan(19, 0, 0), address3, "Weather permitting");

        // Display messages for each event
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\n============================================\n");

        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\n============================================\n");

        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}