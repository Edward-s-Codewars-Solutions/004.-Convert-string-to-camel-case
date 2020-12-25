using System.Text.RegularExpressions;

namespace KataLibrary
{
    public static class Kata
    {
        private const string DashLetterRegexPattern = @"[\-_][a-zA-Z]";

        public static string ToCamelCase(string sentence)
        {
            var dashLetterEvaluator = new MatchEvaluator(MatchToUCaseSecondChar);

            return Regex
                .Replace(sentence, DashLetterRegexPattern, dashLetterEvaluator);
        }

        public static bool IsMatchingDashLetterRegexPattern(string inputString) =>
            Regex.IsMatch(inputString, DashLetterRegexPattern);

        public static string MatchToUCaseSecondChar(Match match)
        {
            int minLength = 2;
            int letterIndex = 1;
            int letterLength = 1;

            return match.Value.Length switch
            {
                int len
                    when len < minLength
                        => default,
                _ => match
                                .Value
                                .Substring(letterIndex, letterLength)
                                .ToUpper()
            };
        }
    }

}
