using System;

public class Kata
{
    public static Tuple<char?, int> LongestRepetition(string input)
    {
        if (string.IsNullOrEmpty(input))
            return new Tuple<char?, int>(null, 0);

        char? longestChar = null;
        int longestCount = 0;
        char currentChar = input[0];
        int currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == currentChar)
            {
                currentCount++;
            }
            else
            {
                if (currentCount > longestCount)
                {
                    longestChar = currentChar;
                    longestCount = currentCount;
                }

                currentChar = input[i];
                currentCount = 1;
            }
        }

        if (currentCount > longestCount)
        {
            longestChar = currentChar;
            longestCount = currentCount;
        }

        return new Tuple<char?, int>(longestChar, longestCount);
    }
}
