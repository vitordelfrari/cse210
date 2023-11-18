public class Word
{
    public string Text { get; }
    public bool IsHidden { get; set; }
    public string HiddenRepresentation { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
        HiddenRepresentation = "";
    }

    public void Hide()
    {
        IsHidden = true;
        HiddenRepresentation = new string('_', Text.Length);
    }

    public override string ToString()
    {
        return IsHidden ? HiddenRepresentation : Text;
    }
}
