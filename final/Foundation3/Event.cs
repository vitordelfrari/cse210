class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GenerateStandardDetails()
    {
        return $"Standard Details:\nTitle: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address.GetFullAddress()}";
    }

    public string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nType: Generic Event";
    }

    public string GenerateShortDescription()
    {
        return $"Short Description:\nType: Generic Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}

