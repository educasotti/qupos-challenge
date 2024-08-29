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
        public void TestWordExistsHorizontally()
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

            // Act
            var result = wordFinder.Find(new List<string> { "abcd" });

            // Assert
            Assert.Contains("abcd", result);
        }

        [Fact]
        public void TestWordExistsVertically()
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

            // Act
            var result = wordFinder.Find(new List<string> { "aeim" });

            // Assert
            Assert.Contains("aeim", result);
        }

        [Fact]
        public void TestWordDoesNotExist()
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

            // Act
            var result = wordFinder.Find(new List<string> { "xyz" });

            // Assert
            Assert.DoesNotContain("xyz", result);
        }

        
    }
}
