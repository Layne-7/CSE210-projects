public class Comments
{
    // Creating the attributes 
    private string _name;
    private string _text;

    // Creating the class constructor (this sets up the way i want to initialize an instance)
    public Comments (string name, string text)
    {
        _name = name;
        _text = text;
    }


    // This method is made for knowing and setting up how our comments will be displayed 
    public string GetDisplay()
    {   
        string text = $"Name: {_name} | Comment: {_text}";
        return text;
    }
}