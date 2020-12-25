using NUnit.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;

[TestFixture]
public class MyUnitTests
{
    private static IEnumerable<TestCaseData> TestCasesForRetrievingUCaseSecondCharOfMatch
    {
        get
        {
            yield return new TestCaseData(StringToMatch("test")).Returns("E");
            yield return new TestCaseData(StringToMatch("tEst")).Returns("E");
            yield return new TestCaseData(StringToMatch("-e")).Returns("E");
            yield return new TestCaseData(StringToMatch("-E")).Returns("E");
            yield return new TestCaseData(StringToMatch("_e")).Returns("E");
            yield return new TestCaseData(StringToMatch("_E")).Returns("E");
            yield return new TestCaseData(StringToMatch("a")).Returns(default(string));
        }
    }

    [Test, TestCaseSource("TestCasesForRetrievingUCaseSecondCharOfMatch")]
    public string MatchToUCaseSecondChar_returns_second_char_of_the_match(Match match) =>
        Kata.MatchToUCaseSecondChar(match);

    private static Match StringToMatch(string inputString)
    {
        string regexPattern = $".{{{ inputString.Length }}}"; // any char repeated for as many times as inputString's length
        return Regex
            .Match(inputString, regexPattern);
    }
}
