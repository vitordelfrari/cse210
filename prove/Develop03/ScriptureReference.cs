public class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    public ScriptureReference(string reference)
    {
        // Parse the reference string and initialize Book, Chapter, StartVerse, EndVerse
        // ...

        // For simplicity, let's assume that the reference is in the format "Book Chapter:StartVerse-EndVerse"
        string[] parts = reference.Split(' ', ':', '-');
        Book = parts[0];
        Chapter = int.Parse(parts[1]);
        StartVerse = int.Parse(parts[2]);
        EndVerse = parts.Length > 3 ? int.Parse(parts[3]) : StartVerse;
    }

    public override string ToString()
    {
        if (StartVerse == EndVerse)
            return $"{Book} {Chapter}:{StartVerse}";
        else
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}