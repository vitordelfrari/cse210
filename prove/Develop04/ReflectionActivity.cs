internal class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    private void ShowReflectionQuestions()
    {
        Random random = new Random();
        int elapsedTime = 0;

        while (elapsedTime < this.duration)
        {
            string randomQuestion = reflectionQuestions[random.Next(reflectionQuestions.Length)];
            Console.WriteLine(randomQuestion);
            ShowSpinner(5); // Pause for 5 seconds with a spinner animation
            elapsedTime += 5; // Adjust the elapsed time based on the pause duration
        }
    }

    public void Start()
    {
        ShowStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        int elapsedTime = 0;
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine(prompt);
        ShowSpinner(2); // Pause for 2 seconds with a countdown
        elapsedTime += 2;

        ShowReflectionQuestions();

        ShowEndingMessage("Reflection Activity", elapsedTime);
    }
}
