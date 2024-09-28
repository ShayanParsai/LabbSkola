
using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb_Shayan
{
    class LabbMath
    {
        List<string> validSubstrings = new List<string>(); // A list to store all the valid substrings.
        public void FindAndPrintValidSubstrings(string input)
        {
            for (int i = 0; i < input.Length; i++) // Performs a linear search to find the substrings
            {
                if (char.IsDigit(input[i])) // If the index is a number, do the rest of the code
                {
                    string tempSubstring = input[i].ToString(); // Temporary subString holder, stores them temporary so we can use them later
                    char startChar = input[i];

                    for (int x = i + 1; x < input.Length; x++) // Look for the matching start and end numbers
                    {
                        if (char.IsDigit(input[x]))  // Add digits to the tempSubstring, ignore letters
                        {
                            tempSubstring += input[x];
                        }
                        else
                        {
                            break; // It found a letter and stops searching further, goes into the next loop.
                        }

                        if (tempSubstring[0] == tempSubstring[tempSubstring.Length - 1]) // Check the first and last index of the substring
                        {
                            bool hasDuplicate = false;

                            for (int j = 1; j < tempSubstring.Length - 1; j++) // Check if we find duplicate of the end and start number inbetween.
                            {
                                if (tempSubstring[j] == startChar) // we compare it with the start number, since we know the start and end is the same.
                                {
                                    hasDuplicate = true;
                                    break; // Exit the loop since we found a duplicate
                                }
                            }
                            if (!hasDuplicate)
                            {
                                validSubstrings.Add(tempSubstring); // if it dosent have dupes, we add it to our list of valid substrings
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\n\nValid substrings highlighted:\n");
            foreach (var substring in validSubstrings)
            {
                HighlightSubstring(input, substring); // we send the original string, and the substring to highlighting workshop :) 
            }
        }

        private void HighlightSubstring(string original, string substring)
        {
            int startIndex = original.IndexOf(substring);
            Console.Write(original.Substring(0, startIndex)); // prints the non highlighted stuff before the highlighted substring

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(substring); // Prints the highlighted substring
            Console.ResetColor();

            Console.WriteLine(original.Substring(startIndex + substring.Length)); // prints the non highlighted stuff after the highlighted substring
        }

        public void AddTheTotalOfTheValidSubStrings()
        {
            long theSumOfTheSubStrings = 0; // We will use long here, since i wasted 2 hours trying to use int and figured its too large to use int :) 

            for (int i = 0; i < validSubstrings.Count; i++)
            {
                theSumOfTheSubStrings += long.Parse(validSubstrings[i]); // parse them to long and store them into theSum
            }
            Console.WriteLine("\n" + theSumOfTheSubStrings);
        }
    }
}