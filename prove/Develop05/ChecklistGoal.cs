public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CompletedCount { get; private set; }

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        CompletedCount = 0;
    }

    public override void RecordEvent()
    {
        CompletedCount++;
        Console.WriteLine($"You've made progress on the {Name} goal. Current count: {CompletedCount}/{TargetCount}.");
        
        if (CompletedCount == TargetCount)
        {
            Console.WriteLine($"Congratulations! You completed the {Name} goal and gained {Value} points.");
        }
    }

    public override string GetProgress()
    {
        return $"Completed {CompletedCount}/{TargetCount} times";
    }
}
