using QuPosChallenge;

var matrix = new List<string>
        {
            "abcdc",
            "fgwio",
            "chill",
            "pqnsd",
            "uvdxy"
        };

var wordStream = new List<string>
        {
            "cold", "wind", "chill", "snow", "chill", "cold", "heat", "rain", "cold", "cold"
        };

var wordFinder = new WordFinder(matrix);
var result = wordFinder.Find(wordStream);

Console.WriteLine("Top 10 Words Found:");
foreach (var word in result)
{
    Console.WriteLine(word);
}
