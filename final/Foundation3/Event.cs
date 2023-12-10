class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address eventAddress;

    private string type;

    public Event(string type, string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.type = type;
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.eventAddress = address;
    }

    // Method to generate standard event details message
    public virtual string GetStandardDetails()
    {
        return $"Standard Details:\nTitle: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString("hh\\:mm")}\nAddress: {eventAddress.GetFullAddress()}";
    }

    // Method to generate full event details message
    public virtual string GetFullDetails()
    {
        return $"Full Details:\nTitle: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString("hh\\:mm")}\nAddress: {eventAddress.GetFullAddress()}\nType: {type}"; 
    }

    // Method to generate short event description message
    public virtual string GetShortDescription()
    {
        return $"Short Description:\nType: {type}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}