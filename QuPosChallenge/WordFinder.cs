using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuPosChallenge
{
    public class WordFinder
    {
        private readonly HashSet<string> _matrixWords;
        private readonly int _rows;
        private readonly int _cols;

        public WordFinder(IEnumerable<string> matrix)
        {
            var matrixList = matrix.ToList();
            _rows = matrixList.Count;
            _cols = matrixList[0].Length;
            _matrixWords = new HashSet<string>();

            // Add horizontal words
            foreach (var row in matrixList)
            {
                _matrixWords.Add(row);
            }

            // Add vertical words
            for (int col = 0; col < _cols; col++)
            {
                var verticalWord = new char[_rows];
                for (int row = 0; row < _rows; row++)
                {
                    verticalWord[row] = matrixList[row][col];
                }
                _matrixWords.Add(new string(verticalWord));
            }
        }

        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            var wordCount = new Dictionary<string, int>();

            foreach (var word in wordstream.Distinct())
            {
                if (_matrixWords.Contains(word))
                {
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    else
                    {
                        wordCount[word] = 1;
                    }
                }
            }

            // Return top 10 most frequent words found in the matrix
            return wordCount.OrderByDescending(kv => kv.Value)
                            .ThenBy(kv => kv.Key) // In case of tie, sort alphabetically
                            .Take(10)
                            .Select(kv => kv.Key);
        }
    }
}
