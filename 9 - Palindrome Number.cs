public class Solution
{
    /// <summary>
    /// Given an integer x, return true is x is a palindrome, and false otherwise. Do not convert the integer to a string.
    /// </summary>
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int forwards = x;
        int backwards = 0;

        while (x > 0)
        {
            backwards *= 10;
            backwards += x % 10;
            x /= 10;
        }

        return forwards == backwards;
    }

    /// <summary>
    /// Given an integer x, return true is x is a palindrome, and false otherwise.
    /// </summary>
    public bool IsPalindrome_StringConversion(int x)
    {
        if (x < 0) { return false; }

        string original = x.ToString();
        int digits = original.Length - 1;

        for (int i = 0; i < digits; i++)
        {
            if (original[i] != original[digits - i])
            {
                return false;
            }
        }
        return true;
    }
}
