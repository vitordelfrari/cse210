public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded the {Name} goal and gained {Value} points.");
    }

    public override string GetProgress()
    {
        return "[ ]";
    }
}