
// Derived class for Outdoor Gathering events
class OutdoorGathering : Event
{
    private string weatherStatement;

    public OutdoorGathering(string type, string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement)
        : base(type, title, description, date, time, address)
    {
        this.weatherStatement = weatherStatement;
    }

    // Override method to generate full details for Outdoor Gathering events
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather Statement: {weatherStatement}";
    }
}
