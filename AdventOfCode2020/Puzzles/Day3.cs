using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Puzzles
{
    public static class Day3
    {
        public static void ExecutePart1(IEnumerable<string> input)
        {
            int treeCount = 0;
            int openCount = 0;
            int cursor = 0;

            // 31 chars on each line, indexed 0-30
            int modulator = 31;

            for (int i = 1; i < input.Count(); i++)
            {
                cursor = (cursor + 3) % modulator;
                //Console.WriteLine($"Cursor: {cursor}");
                string line = input.ElementAt(i);
                //Console.WriteLine($"Line: {line}");
                char currentChar = line.ToCharArray().ElementAt(cursor);
                //Console.WriteLine($"Char: {currentChar}");

                if (currentChar == '.')
                {
                    openCount++;
                }
                else
                {
                    treeCount++;
                }
            }

            Console.WriteLine($"Number of trees: {treeCount}");
            Console.WriteLine($"Number of open spaces: {openCount}");
        }
    
        public static void ExecutePart2(IEnumerable<string> input)
        {
            var slopes = new List<(int, int)>
            {
                (1,1),
                (3,1),
                (5,1),
                (7,1),
                (1,2)
            };
            var currentProduct = 1;

            // 31 chars on each line, indexed 0-30
            int modulator = 31;
            
            foreach (var slope in slopes)
            {
                int treeCount = 0;
                int openCount = 0;
                int cursor = 0;
                int right = slope.Item1;
                int down = slope.Item2;

                for (int i = down; i < input.Count(); i += down)
                {
                    cursor = (cursor + right) % modulator;
                    //Console.WriteLine($"Cursor: {cursor}");
                    string line = input.ElementAt(i);
                    //Console.WriteLine($"Line: {line}");
                    char currentChar = line.ToCharArray().ElementAt(cursor);
                    //Console.WriteLine($"Char: {currentChar}");

                    if (currentChar == '.')
                    {
                        openCount++;
                    }
                    else
                    {
                        treeCount++;
                    }
                }

                //Console.WriteLine($"Number of trees: {treeCount}");
                //Console.WriteLine($"Number of open spaces: {openCount}");
                //Console.WriteLine($"Product of trees: {currentProduct} * {treeCount} = {currentProduct * treeCount}");
                currentProduct *= treeCount;
            }

            Console.WriteLine($"Product of trees: {currentProduct}");
        }
    }
}