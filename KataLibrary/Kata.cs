using System;
using System.Text.RegularExpressions;

public static class Kata
{
    private const string DashLetterRegexPattern = @"[\-\_][a-zA-Z]";

    public static string ToCamelCase(string sentence)
    {
        
    }

    public static string MatchToUCaseSecondChar(Match match)
    {
        int letterIndex = 1;
        int letterLength = 1;
        return match
            .Value
            .Substring(letterIndex, letterLength)
            .ToUpper();
    }
}
