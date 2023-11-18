public class Scripture
{
    private List<Word> words;
    private ScriptureReference reference;

    public Scripture(string reference, string text)
    {
        this.reference = new ScriptureReference(reference);
        InitializeWords(text);
    }

    private void InitializeWords(string text)
    {
        // Split the text into words and initialize the list of Word objects
        // ...

        // For simplicity, let's assume that words are separated by spaces
        string[] wordArray = text.Split(' ');
        words = new List<Word>();

        foreach (var word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference);
        foreach (var word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
    List<Word> availableWords = words.FindAll(word => !word.IsHidden);

    if (availableWords.Count > 0)
    {
        Random random = new Random();
        int index = random.Next(availableWords.Count);
        availableWords[index].Hide();
        return true;
    }

    return false;
    }

    public bool AreAllWordsHidden()
    {
        foreach (var word in words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
    
    public List<Word> GetWords()
    {
        return words;
    }
}
