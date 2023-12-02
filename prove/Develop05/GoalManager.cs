public class GoalManager
{
    private List<Goal> goals;
    private int points;

    public GoalManager()
    {
        goals = new List<Goal>();
        points = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name} - {goals[i].GetProgress()}");
        }
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal currentGoal = goals[index];

            if (currentGoal != null)
            {
                Console.WriteLine($"You recorded the {currentGoal.Name} goal and gained {currentGoal.GetValue()} points.");
                currentGoal.RecordEvent();
                points += currentGoal.GetValue();
                Console.WriteLine($"Total points: {points}");
            }
            else
            {
                Console.WriteLine("Invalid goal reference.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayProgress()
    {
        Console.WriteLine("\nGoals Progress:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}: {goals[i].GetProgress()}");
        }
    }

    public int GoalCount()
    {
        return goals.Count;
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {points} points.");
    }

    public void ShowMenu()
    {
        Console.WriteLine("1- Create new goal");
        Console.WriteLine("2- List goals");
        Console.WriteLine("3- Save goals");
        Console.WriteLine("4- Load goals");
        Console.WriteLine("5- Record event");
        Console.WriteLine("6- Quit");
    }

    public void SaveGoals(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                {
                    if (goal != null)
                    {
                        writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.GetValue()},{goal.GetProgress()}");

                        if (goal is ChecklistGoal checklistGoal)
                        {
                            writer.WriteLine($"{checklistGoal.CompletedCount},{checklistGoal.TargetCount},{checklistGoal.BonusPoints}");
                        }
                    }
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals(string fileName)
    {
        try
        {
            goals.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] components = line.Split(',');

                    if (components.Length >= 4)
                    {
                        string type = components[0];
                        string name = components[1];
                        int value = int.Parse(components[2]);

                        switch (type)
                        {
                            case nameof(SimpleGoal):
                                goals.Add(new SimpleGoal(name, value));
                                break;
                            case nameof(EternalGoal):
                                goals.Add(new EternalGoal(name, value));
                                break;
                            case nameof(NegativeGoal):
                                goals.Add(new NegativeGoal(name, value));
                                break;
                            case nameof(ChecklistGoal):
                                if (components.Length >= 7)
                                {
                                    int completedCount = int.Parse(components[3]);
                                    int targetCount = int.Parse(components[4]);
                                    int bonusPoints = int.Parse(components[5]);
                                    goals.Add(new ChecklistGoal(name, value, completedCount, targetCount, bonusPoints));
                                }
                                else
                                {
                                    Console.WriteLine($"Missing data for {nameof(ChecklistGoal)}. Skipping. Components: {string.Join(",", components)}");
                                }
                                break;
                            default:
                                Console.WriteLine($"Unknown goal type: {type}. Skipping.");
                                break;
                        }
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}
