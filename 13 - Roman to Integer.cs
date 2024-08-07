public class Solution
{
    /// <summary>
    /// Given a roman numeral, convert it to an integer.
    /// </summary>
    public int RomanToInt(string s)
    {
        Dictionary<char, int> keyValues = new Dictionary<char, int>
        {
            { 'M', 1000 },
            { 'D', 500 },
            { 'C', 100 },
            { 'L', 50 },
            { 'X', 10 },
            { 'V', 5 },
            { 'I', 1 }
        };

        int number = 0;

        for (int i = s.Length - 1; i >= 1; i--)
        {
            int toAdd = keyValues[s[i]];
            number += toAdd;

            int nextValue = keyValues[s[i - 1]];
            if (nextValue < toAdd)
            {
                number -= nextValue;
                i--;
            }
        }

        int first = keyValues[s[0]];

        if (s.Length == 1)
        {
            return number + first;
        }

        int second = keyValues[s[1]];
        if (first >= second)
        {
            return number + first;
        }

        return number;
    }
}
