using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers (type 0 when finished): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = 0;
        int max = int.MinValue; // Initialize max to the smallest possible value
        int minPositive = int.MaxValue; // Initialize minPositive to the largest possible value

        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }

            if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The max is: {max}");

        // Part 2: Find the smallest positive number closest to zero
        if (minPositive == int.MaxValue)
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number closest to zero is: {minPositive}");
        }

        // Part 3: Sort the list
        numbers.Sort();
        Console.WriteLine("Sorted list: " + string.Join(", ", numbers));
    }
}
