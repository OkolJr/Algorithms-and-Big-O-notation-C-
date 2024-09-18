using System;

class WildcardPatternMatching
{
    public static bool IsMatch(string text, string pattern)
    {
        int textIndex = 0, patternIndex = 0, starIndex = -1, matchIndex = 0;

        while (textIndex < text.Length)
        {
            // If the pattern character is '?' or the characters match
            if (patternIndex < pattern.Length && (pattern[patternIndex] == '?' || pattern[patternIndex] == text[textIndex]))
            {
                textIndex++;
                patternIndex++;
            }
            // If the pattern character is '*'
            else if (patternIndex < pattern.Length && pattern[patternIndex] == '*')
            {
                // Store the position of '*' and matchIndex
                starIndex = patternIndex;
                matchIndex = textIndex;
                patternIndex++;
            }
            // If the pattern character is not '?' or '*' and characters do not match
            else if (starIndex != -1)
            {
                // Backtrack: '*' can match this character, try the next character
                patternIndex = starIndex + 1;
                matchIndex++;
                textIndex = matchIndex;
            }
            else
            {
                // No match
                return false;
            }
        }

        // Check for remaining '*' in the pattern
        while (patternIndex < pattern.Length && pattern[patternIndex] == '*')
        {
            patternIndex++;
        }

        // If the pattern is fully matched
        return patternIndex == pattern.Length;
    }

    static void Main()
    {
        string text = "helloWorld";
        string pattern = "he*o?orld";

        bool result = IsMatch(text, pattern);
        Console.WriteLine(result ? "Pattern matches!" : "Pattern does not match.");
    }
}