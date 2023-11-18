using System;
using System.Collections.Generic;

public class Program
{
    private static List<Scripture> scriptures;

    static void Main()
    {
        InitializeScriptures();

        do
        {
            var currentScripture = GetRandomScripture();
            PlayGame(currentScripture);

            Console.WriteLine("Press Enter to play again or type 'quit' to exit.");
        } while (Console.ReadLine().ToLower() != "quit");
    }

    private static void PlayGame(Scripture scripture)
    {
        do
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("Press Enter to continue, type 1 to reset words, 2 to change scripture, or 3 to quit.");

            var userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "1":
                    ResetHiddenWords(scripture);
                    break; // Continue with the same scripture
                case "2":
                    return; // Change the scripture
                case "3":
                    Environment.Exit(0); // Quit the program
                    break;
                default:
                    scripture.HideRandomWord();
                    break;
            }

        } while (!scripture.AreAllWordsHidden());
    }

    private static void ResetHiddenWords(Scripture scripture)
    {
        foreach (var word in scripture.GetWords())
        {
            word.IsHidden = false;
        }
    }

    private static void InitializeScriptures()
    {
        
        scriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture("Psalm 23:1", "The LORD is my shepherd; I shall not want."),
            new Scripture("Romans 8:28", "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            new Scripture("Matthew 6:33", "But seek first his kingdom and his righteousness, and all these things will be given to you as well."),
            // Add more scriptures as needed
        };
    }

    private static Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        return scriptures[index];
    }
}
