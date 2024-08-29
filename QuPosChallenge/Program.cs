using QuPosChallenge;

var matrix = new List<string>(File.ReadAllLines("matrix.txt"));


var wordStream = new List<string>(File.ReadAllLines("wordstream.txt"));


var wordFinder = new WordFinder(matrix);
var result = wordFinder.Find(wordStream);
if(result.Count() == 0)
{
    Console.WriteLine("No words were found.");
    return;
}
else
{
    Console.WriteLine("Top 10 Words Found:");
    foreach (var word in result)
    {
        Console.WriteLine(word);
    }
}

