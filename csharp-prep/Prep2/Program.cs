using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int g = int.Parse(grade);

        string letter = "";

        if (g >= 90)
        {
            letter = "A";
        }
        else if (g >= 80)
        {
            letter = "B";
        }
        else if (g >= 70)
        {
            letter = "C";
        }
        else if (g >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (+ or -)
        int lastDigit = g % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle exceptional cases
        if (letter == "A" && sign == "+")
        {
            letter = "A";
            sign = "";
        }
        else if (letter == "F" && (sign == "+" || sign == "-"))
        {
            letter = "F";
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (g >= 70)
        {
            Console.WriteLine("Congratulations, you passed on your exam!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
