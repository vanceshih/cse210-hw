
// Derived class for Lecture events
class Lecture : Event
{
    private string speaker;
    private int capacity;


    public Lecture(string type, string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(type, title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
        
    }

    // Override method to generate full details for Lecture events
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker: {speaker}\nCapacity: {capacity} attendees";
    }
}