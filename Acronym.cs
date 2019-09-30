using System;
using System.Collections.Generic;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        // the aim is to obtain every letter after a delimiter (space, hyphen, underscore etc)

        // acronym will be in all upper case so convert input to upper case
        string phraseUpperCase = phrase.ToUpper();

        // declare list of characters
        List<char> FirstLetters = new List<char>();

        // get position of first letter in case string starts with delimiters
        int firstLetterIndex =  phraseUpperCase.ToList().FindIndex(c => char.IsLetter(c));

        // Add first letter to list
        FirstLetters.Add(phraseUpperCase[firstLetterIndex]);

        // starting with character after first letter, if previous character is not a letter and current character
        // is a letter then add to the list
        for (int i = 1 + firstLetterIndex; i < phraseUpperCase.Length; i++)
        {
            // convert current character into ASCII value
            char x = (char)phraseUpperCase[i];

            // convert previous character into ASCII value
            char y = (char)phraseUpperCase[i - 1];

            // if current character is a letter proceed
            if (Char.IsLetter(x))
            {
                // if previous character is a letter or apostrophe, do nothing else add to list
                if (Char.IsLetter(y)||y==39)
                {

                }
                else
                {
                    FirstLetters.Add(x);
                }
            }
        }
        // the list should now be filled with the letters for an acronym

        // declare empty string
        string acronym = "";

        // for each character in the list object append the character onto the acronym string
        foreach (char c in FirstLetters)
        {
            acronym = acronym + c;
        }

        // return complete acronym string
        return acronym;
    }
}