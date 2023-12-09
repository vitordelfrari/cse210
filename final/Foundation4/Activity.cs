class Activity
{
    private DateTime date;
    protected int durationMinutes; // Change from private to protected

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation for activities without distance calculation
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation for activities without speed calculation
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation for activities without pace calculation
    }

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} - {GetType().Name} ({durationMinutes} min)";
    }
}