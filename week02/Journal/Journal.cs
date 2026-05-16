using System.Security.Cryptography.X509Certificates;

public class Journal
{
    //List that stores all the entries
    List<Entry> _entries = new List<Entry>();

    // Adding a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // It displays all the entries on the screen
    public void DisplayAll() // this is a function to Display entries
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The Journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display(); // this will Display every entry on the screen
        }
    }

    // Now we need to save the entries in a txt file, which is an option
    public void SaveToFile(string file)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {   // Each entry will turn into a line separated by a "|"
            lines.Add($"{entry._date} | {entry._promptText} | {entry._entryText}");
        }

        File.WriteAllLines(file, lines);
        Console.WriteLine($"Journal saved in '{file}'.");
    }

    // Loading the entries from a .txt file
    public void LoadFromFile(string file)
    {
        _entries.Clear(); // this cleans what was in the memory

        // File.WriteAllLines and File ReadAllLines are buit-in methods in C# to work w files.
        // String [] means array, a list with constant length, unlike List<string> that does not 
        // have a pre defined length.
        string [] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string [] parts = line.Split("|"); // this divides the line for a "|"
            Entry entry = new Entry(parts[0], parts[1], parts[2]);
            // parts[0] = "04/15/2024"
            // parts[1] = "How was your day?"
            // parts[2] = "It was great!"
            _entries.Add(entry);
        }
        
        Console.WriteLine($"Journal loaded from '{file}'.");
    }
}