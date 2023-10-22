class Reference
{
    public string Verse { get; private set; }
    public string Book { get; private set; }

    public Reference(string referenceText)
    {
        string[] parts = referenceText.Split(' ');
        if (parts.Length == 2)
        {
            Book = parts[0];
            Verse = parts[1];
        }
        else
        {
            // Handle invalid reference format
            Book = "Invalid";
            Verse = "Invalid";
        }
    }

    public string ReferenceText
    {
        get { return Book + " " + Verse; }
    }
}
