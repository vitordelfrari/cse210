public class NegativeGoal : Goal
{
    public NegativeGoal(string name, int penalty) : base(name, -penalty)
    {
        // Use the base constructor to set the name and initial value (penalty)
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Oops! You engaged in the {Name} habit and lost {Value} points.");
    }

    public override string GetProgress()
    {
        return "Negative goal, points deducted for bad habits.";
    }
}
