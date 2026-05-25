using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

public class Scripture
{
    // The attributes 
    private Reference _reference; // this is an instance/object
    private List<Word> _words; // this list stores objects of the word type

    public Scripture(Reference reference, string text) // the constructor for this class
    {
        _reference = reference; // reference stores whatever is written into this variable
        _words = new List<Word>(); // This creates an empty words list

        foreach (string word in text.Split(' ')) // for each word in the text, "Split" will separate them
        // into a list, something like ["i", "love", "C#"]
        {
            _words.Add(new Word(word)); // this line turns every word of the text into a Word object
            // and add them into the main list _words (which is a list of word objects.)

            // example: string word = "love"
            // now: Word("love")
        }
    }

    public void HideRandomWords(int numberToHide) // this is a method for hiding a certain amount of 
    // random words
    {
        Random random = new Random(); // this creates a Random object, so you can use its methods.
        
        for (int i = 0; i < numberToHide; i++) // this loop will continue until "i" hits 'numberToHide"
        {
            int randomIndex = random.Next(_words.Count); // random.Next() picks a random number 
            // _words.Count gets the length of the list, then the random number is stored into a variable.
            _words[randomIndex].Hide(); // to access a certain value in a list, you have to open [] and 
        // type in the index, then "Hide()" will hide that value.
        }
        
    }

    public string GetDisplayText()
    {
        List<string> words = new List<string>(); // Creating an empty list to add the value of each word.

        foreach (Word word in _words) // this is the list of words that were made objects
        {   
            // when adding word in the list words, it is actually adding the output of GetDisplayText
            // of each word, as the method returns either the hidden word "___" or the text itself.
            words.Add(word.GetDisplayText());
        }


        return $"{_reference.GetDisplayText()} \n{string.Join(" ", words)}";
    }   // builds and returns a single string: the reference display text, a line break, then all words
        // joined with spaces.
        // example: [word1], [word2], [word3]
        // using string.Join: word1 word2 word3 (separated by spaces)


    // boolean method to check if the entire text is hidden or not
    // it'll iterate through every word in the list _words to check if they're hidden or not
    public bool isCompletelyHidden()
    {
        foreach (Word word in _words) // for each word in the list _words...
        {
            if (!word.IsHidden()) // if a word is not hidden then return false, "!" is like a "not"
            {
                return false;
            }
        }

        return true; // if all the words are hidden, then return true.
    }

}