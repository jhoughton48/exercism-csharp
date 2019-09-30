using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {

        if (input.Length < 26)
        {
            return false;
        }
        else
        {

            // declare list of zero elements
            List<char> list = new List<char>();

            // convert input string to all lower case to reduce ASCII checks
            string lowerCaseInput = input.ToLower();

            for (int i = 0; i <= lowerCaseInput.Length-1; i++)
            {
                // obtain character in string of index i
                char c = lowerCaseInput[i];

                // convert to ASCII value
                int ascRef = (int)c;

                // if ASCII value is an alpha value and it doesn't already exists in the list then add to the list
                if (ascRef >= 97 && ascRef <= 122 && list.Contains(c) == false)
                {
                    list.Add(c);
                }

            }

            if (list.Count == 26)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
