using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        // default boolean to true if empty string
       bool isIsogram = true;

        // declare variable for string of input to lower case
        string lowerCase = word.ToLower();

        // obtain length of input
        int inputlength = lowerCase.Length;

        // declare list of characters
        List<char> list = new List<char>();

        // loop through all characters in input
        for(int i = 0; i < inputlength; i++)
        {
            // convert each character into ASCII value
            char c = (char)lowerCase[i];

            if(list.Contains(c) && (c != 95) && (c != 45) && (c != 32))
            {
                isIsogram = false;
            }
            else
            {
                list.Add(c);
            }
        }

        return isIsogram;

    }
}
