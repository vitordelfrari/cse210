internal class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}, ");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    public void Start()
    {
        // Standard starting message and prompt for duration
        ShowStartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int elapsedTime = 0;
        int breathDuration = 3; // Duration for each breath (in and out)

        while (elapsedTime < this.duration)
        {
            // Breathe in...
            Console.Write("Breathe in... ");
            ShowCountdown(breathDuration);
            Console.WriteLine();

            elapsedTime += breathDuration;

            // Breathe out...
            Console.Write("Breathe out... ");
            ShowCountdown(breathDuration);
            Console.WriteLine();

            elapsedTime += breathDuration;
        }

        // Standard ending message for all activities
        ShowEndingMessage("Breathing Activity", elapsedTime);
    }
}
