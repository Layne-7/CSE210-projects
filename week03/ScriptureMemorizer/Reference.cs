public class Reference
{   // These are the attributes (i think we can call it variables)
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Buiding the first constructor (it means that if you put only 3 arguments when creating the instance,
    // that's the one constructor C# will use).
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Building the second constructor (it means that if you type in 4 arguments when creating the object,
    // that's the constructor C# will use).
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Creating the display method (it must be a string method cuz it will display something)
    public string GetDisplayText()
    {
        // if the end verse is equal to the verse, that means there is only one verse
        // if the end verse is equal to 0, that also means its only that one verse
        if (_endVerse == _verse || _endVerse == 0)  // || means "or"
        {
            return $"{_book} {_chapter}:{_verse}"; // it returns book, chapter and one verse
        }

        // If the end verse is different than the first verse or different than 0, that means
        // it has more than one verse to read through.
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
