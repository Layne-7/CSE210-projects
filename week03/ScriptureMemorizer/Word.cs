public class Word
{   
    // These are the attributes for this class 
    private string _text;
    private bool _isHidden;

    public Word(string text) // this is the constructor for the instance 
    // it means that it'll initially start with a text and its value set as false.
    {
        _text = text;
        _isHidden = false;
    }

    // This is the public method that will be responsible for displaying our output 
    public string GetDisplayText()
    {
        // if the word is hidden, then our display must be "___"
        if (_isHidden)
        {
            return "___";
        }
        else
        {
            return _text; // if _isHidden is false, then our display must show the word itself.
        }
    }


    // This is a method to hide a word, then _isHidden has to be true
    public void Hide()
    {
        _isHidden = true;
    }

    // This is a method to show a word, then _isHidden has to be false
    public void Show()
    {
        _isHidden = false;
    }

    // This is a method made in order to get the private value of the attribute in this class and use it
    //  in other parts of our code or main program without compromising its data integrity.
    // its purpose is to check if a word is hidden or not, its output should either be true or false.
    public bool IsHidden()
    {
        return _isHidden;
    }

}