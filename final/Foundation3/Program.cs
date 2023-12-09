using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");
        Address address3 = new Address("789 Pine St", "Villagetown", "FL", "USA");

        // Create events
        Event genericEvent = new Event("Generic Event", "An event with no specific type", DateTime.Now, TimeSpan.FromHours(2), address1);
        Lecture lectureEvent = new Lecture("Tech Talk", "An informative session on technology", DateTime.Now.AddDays(7), TimeSpan.FromHours(3), address2, "John Doe", 50);
        Reception receptionEvent = new Reception("Networking Mixer", "A social gathering for networking", DateTime.Now.AddDays(14), TimeSpan.FromHours(4), address3, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Picnic in the Park", "A fun outdoor picnic", DateTime.Now.AddDays(21), TimeSpan.FromHours(5), address1, "Sunny with a chance of rain");

        // Display marketing messages
        Console.WriteLine(genericEvent.GenerateStandardDetails());
        Console.WriteLine(genericEvent.GenerateFullDetails());
        Console.WriteLine(genericEvent.GenerateShortDescription());
        Console.WriteLine("\n-----------------------------------------\n");

        Console.WriteLine(lectureEvent.GenerateStandardDetails());
        Console.WriteLine(lectureEvent.GenerateFullDetails());
        Console.WriteLine(lectureEvent.GenerateShortDescription());
        Console.WriteLine("\n-----------------------------------------\n");

        Console.WriteLine(receptionEvent.GenerateStandardDetails());
        Console.WriteLine(receptionEvent.GenerateFullDetails());
        Console.WriteLine(receptionEvent.GenerateShortDescription());
        Console.WriteLine("\n-----------------------------------------\n");

        Console.WriteLine(outdoorEvent.GenerateStandardDetails());
        Console.WriteLine(outdoorEvent.GenerateFullDetails());
        Console.WriteLine(outdoorEvent.GenerateShortDescription());
    }
}
