using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuPosChallenge
{
    public class WordFinder
    {
        private readonly char[,] _matrix;
        private readonly int _rows;
        private readonly int _cols;

        public WordFinder(IEnumerable<string> matrix)
        {
            _rows = matrix.Count();
            _cols = matrix.First().Length;
            _matrix = new char[_rows, _cols];

            Validations();
            int row = 0;
            foreach (var line in matrix)
            {
                for (int col = 0; col < _cols; col++)
                {
                    _matrix[row, col] = line[col];
                }
                row++;
            }
        }

        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            var wordSet = new HashSet<string>(wordstream); // Unique words
            var wordCount = new Dictionary<string, int>();

            foreach (var word in wordSet)
            {
                if (WordExists(word))
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }
            }

            return wordCount
                .OrderByDescending(kvp => kvp.Value)
                .Take(10)
                .Select(kvp => kvp.Key);
        }

        private bool WordExists(string word)
        {
            int wordLength = word.Length;

            // Check horizontally
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col <= _cols - wordLength; col++)
                {
                    bool match = true;
                    for (int i = 0; i < wordLength; i++)
                    {
                        if (_matrix[row, col + i] != word[i])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match) return true;
                }
            }

            // Check vertically
            for (int col = 0; col < _cols; col++)
            {
                for (int row = 0; row <= _rows - wordLength; row++)
                {
                    bool match = true;
                    for (int i = 0; i < wordLength; i++)
                    {
                        if (_matrix[row + i, col] != word[i])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match) return true;
                }
            }

            return false;
        }

        void Validations()
        {
            //validate if the matrix is a square
            if (_rows != _cols)
            {
                throw new ArgumentException("Matrix must be a square");
            }
            //validate if the matrix does not exceed 64x64
            if (_rows > 64 || _cols > 64)
            {
                throw new ArgumentException("Matrix cannot exceed 64x64");
            }
        }

    }
}
