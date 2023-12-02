public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int BonusPoints { get; private set; }
    public int CompletedCount { get; private set; }

    public ChecklistGoal(string name, int value, int completedCount, int targetCount, int bonusPoints)
        : base(name, value)
    {
        CompletedCount = completedCount;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        CompletedCount++;

        if (CompletedCount < TargetCount)
        {
            Console.WriteLine($"Congratulations! You completed the {Name} goal and gained {Value} points.");
        }
        else
        {
            int totalPoints = Value * TargetCount + BonusPoints;
            Console.WriteLine($"Congratulations! You completed the {Name} goal {TargetCount} times and gained {totalPoints} points, including a bonus of {BonusPoints} points.");
        }
    }

    public override string GetProgress()
    {
        return $"Completed {CompletedCount}/{TargetCount} times";
    }

    // Add this method to properly serialize ChecklistGoal
    public override string ToString()
    {
        return $"{base.ToString()},{CompletedCount},{TargetCount},{BonusPoints}";
    }
}
