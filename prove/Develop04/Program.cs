class Program
{
    static int breathingActivityCount = 0;
    static int reflectionActivityCount = 0;
    static int listingActivityCount = 0;

    static void Main()
    {
        Console.WriteLine("Welcome to the Activity Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. See Activity Counts");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    breathingActivityCount++;
                    break;
                case "2":
                    RunReflectionActivity();
                    reflectionActivityCount++;
                    break;
                case "3":
                    RunListingActivity();
                    listingActivityCount++;
                    break;
                case "4":
                    PrintActivityCounts();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }

    static void RunBreathingActivity()
    {
        Console.Write("Enter the duration in seconds for the Breathing Activity: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            BreathingActivity breathingActivity = new BreathingActivity(duration);
            breathingActivity.Start();
        }
        else
        {
            Console.WriteLine("Invalid input for duration. Please enter a valid number.");
        }
    }

    static void RunReflectionActivity()
    {
        Console.Write("Enter the duration in seconds for the Reflection Activity: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
            reflectionActivity.Start();
        }
        else
        {
            Console.WriteLine("Invalid input for duration. Please enter a valid number.");
        }
    }

    static void RunListingActivity()
    {
        Console.Write("Enter the duration in seconds for the Listing Activity: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            ListingActivity listingActivity = new ListingActivity(duration);
            listingActivity.Start();
        }
        else
        {
            Console.WriteLine("Invalid input for duration. Please enter a valid number.");
        }
    }

    static void PrintActivityCounts()
    {
        Console.WriteLine("\nActivity Counts:");
        Console.WriteLine($"Breathing Activity Count: {breathingActivityCount}");
        Console.WriteLine($"Reflection Activity Count: {reflectionActivityCount}");
        Console.WriteLine($"Listing Activity Count: {listingActivityCount}");
    }
}
