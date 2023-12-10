
// Derived class for Reception events
class Reception : Event
{    
    private string rsvpEmail;

    public Reception(string type, string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(type, title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    // Override method to generate full details for Reception events
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP Email: {rsvpEmail}";
    }
}