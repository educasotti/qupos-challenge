using QuPosChallenge;
using System.Collections.Generic;
using Xunit;

namespace QuPosChallenge.Tests
{
    public class QuPosChallengeTests
    {
        [Fact]
        public void TestFindWordsInMatrix()
        {
            // Arrange
            var matrix = new List<string>
            {
                "abcd",
                "efgh",
                "ijkl",
                "mnop"
            };
            var wordFinder = new WordFinder(matrix);
            var wordstream = new List<string> { "abcd", "efgh", "ijkl", "mnop", "aeim", "bfjn", "cgko", "dhlp", "xyz" };

            // Act
            var result = wordFinder.Find(wordstream);

            // Assert
            var expected = new List<string> { "abcd", "efgh", "ijkl", "mnop", "aeim", "bfjn", "cgko", "dhlp" };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestFindTop10WordsInMatrix()
        {
            // Arrange
            var matrix = new List<string>
            {
                "abcd",
                "efgh",
                "ijkl",
                "mnop"
            };
            var wordFinder = new WordFinder(matrix);
            var wordstream = new List<string> { "abcd", "abcd", "abcd", "efgh", "ijkl", "mnop", "mnop", "mnop", "mnop", "mnop", "mnop", "mnop", "mnop", "mnop", "mnop" };

            // Act
            var result = wordFinder.Find(wordstream);

            // Assert
            var expected = new List<string> { "mnop", "abcd", "efgh", "ijkl" };
            Assert.Equal(expected, result);
        }
    }
}