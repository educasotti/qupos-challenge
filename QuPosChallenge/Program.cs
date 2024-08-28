using QuPosChallenge;

var matrix = new List<string>
        {
            "cold",
            "wind",
            "chll",
            "abcd"
        };

var wordStream = new List<string>
        {
            "cold", "wind", "chill", "snow", "wind", "cold", "heat", "rain", "cold", "cold"
        };

var wordFinder = new WordFinder(matrix);
var result = wordFinder.Find(wordStream);

Console.WriteLine("Top 10 Words Found:");
foreach (var word in result)
{
    Console.WriteLine(word);
}
