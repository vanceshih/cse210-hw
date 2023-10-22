class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; set; }

    public Word(string text, bool isHidden)
    {
        Text = text;
        IsHidden = isHidden;
    }
}
