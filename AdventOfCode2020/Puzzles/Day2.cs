using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Puzzles
{
    public static class Day2
    {
        private static int ParseFirstNumber(string inputLine)
        {
            return int.Parse(inputLine.Split(' ')[0].Split('-')[0]);
        }

        private static int ParseSecondNumber(string inputLine)
        {
            return int.Parse(inputLine.Split(' ')[0].Split('-')[1]);
        }

        private static string ParseLetter(string inputLine)
        {
            return inputLine.Split(' ')[1].Substring(0, 1);
        }

        private static string ParsePassword(string inputLine)
        {
            return inputLine.Split(' ')[2];
        }

        public static void ExecutePart1(IEnumerable<string> input)
        {
            var invalidLines = new List<string>();

            foreach (string line in input)
            {
                int min = ParseFirstNumber(line);
                int max = ParseSecondNumber(line);
                string letter = ParseLetter(line);
                string password = ParsePassword(line);
                string trimmed = password.Replace(letter, "");
                int occurrences = password.Length - trimmed.Length;

                if (occurrences < min || occurrences > max)
                {
                    Console.WriteLine($"Invalid password: {line}");
                    invalidLines.Add(line);
                }
            }

            Console.WriteLine($"Number of invalid passwords: {invalidLines.Count}");
            Console.WriteLine($"Number of valid passwords: {input.Count() - invalidLines.Count}");
        }
    
        public static void ExecutePart2(IEnumerable<string> input)
        {
            var invalidLines = new List<string>();

            foreach (string line in input)
            {
                int firstIndex = ParseFirstNumber(line);
                int secondIndex = ParseSecondNumber(line);
                string letter = ParseLetter(line);
                string password = ParsePassword(line);

                if (password.Length < secondIndex ||
                    !(password.ElementAt(firstIndex - 1) == letter[0] ^ password.ElementAt(secondIndex - 1) == letter[0]))
                {
                    Console.WriteLine($"Invalid password: {line}");
                    invalidLines.Add(line);
                }
            }

            Console.WriteLine($"Number of invalid passwords: {invalidLines.Count}");
            Console.WriteLine($"Number of valid passwords: {input.Count() - invalidLines.Count}");
        }
    }
}