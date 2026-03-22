using UtilityLibraries;

namespace StringLibraryTests;

[TestClass]
public sealed class StringLibraryTests
{
    [TestMethod]
    public void TestStartsWithUpper()
    {
        string[] words = ["Alphabet", "Zebra", "ABC", "Αθήνα", "Москва"];

        foreach (string word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.IsTrue(result, $"Expected for '{word}': true; Actual: {result}");
        }
    }

    [TestMethod]
    public void TestDoesNotStartWithUpper()
    {
        string[] words = ["alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство", "1234", ".", ";", " "];

        foreach (string word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.IsFalse(result, $"Expected for '{word}': false; Actual: {result}");
        }
    }

    [TestMethod]
    public void DirectCallWithNullOrEmpty()
    {
        string?[] words = [string.Empty, null];

        foreach (string? word in words)
        {
            bool result = StringLibrary.StartsWithUpper(word);
            Assert.IsFalse(result, $"Expected for '{word ?? "<null>"}': false; Actual: {result}");
        }
    }
}
