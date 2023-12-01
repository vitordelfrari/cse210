public class SimpleGoal : Goal
{
    public bool IsCompleted { get; private set; }

    public SimpleGoal(string name, int value) : base(name, value)
    {
        IsCompleted = false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You completed the {Name} goal and gained {Value} points.");
        IsCompleted = true;
    }

    public override string GetProgress()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}
