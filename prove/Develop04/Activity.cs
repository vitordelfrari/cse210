// Base class for all activities
internal class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    protected void ShowStartingMessage(string activityName, string description)
    {
        Console.WriteLine($"{activityName} - {description}");
        Console.WriteLine($"Set duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds with a spinner animation
    }

    protected void ShowEndingMessage(string activityName, int elapsedTime)
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {activityName} in {elapsedTime} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds with a spinner animation
    }

     protected void ShowSpinner(int duration)
    {
        Console.CursorVisible = false;
        for (int i = 0; i < duration * 2; i++)
        {
            Console.Write("-");
            Thread.Sleep(500); // Pause for 0.5 seconds
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.CursorVisible = true;
    }
}