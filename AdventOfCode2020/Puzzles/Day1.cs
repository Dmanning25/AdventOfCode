using System;
using System.Collections.Generic;

namespace AdventOfCode2020.Puzzles
{
    public static class Day1
    {
        public static void ExecutePart1(int[] numbers)
        {
            int x = -1;
            int y = -1;
            bool found = false;

            for (x = 0; x < numbers.Length; x++)
            {
                for (y = x; y < numbers.Length; y++)
                {
                    if (numbers[x] + numbers[y] == 2020)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Match found!");
                Console.WriteLine($"First index: [{x}]; Value: {numbers[x]}");
                Console.WriteLine($"Second index: [{y}]; Value: {numbers[y]}");
                Console.WriteLine($"Added together: {numbers[x]} + {numbers[y]} = {numbers[x] + numbers[y]}");
                Console.WriteLine($"Multiplied together: {numbers[x]} * {numbers[y]} = {numbers[x] * numbers[y]}");
            }
            else
            {
                Console.WriteLine("Match not found.");
            }
        }
    
        public static void ExecutePart2(int[] numbers)
        {
            int x = -1;
            int y = -1;
            int z = -1;
            bool found = false;

            for (x = 0; x < numbers.Length; x++)
            {
                for (y = x; y < numbers.Length; y++)
                {
                    for (z = y; z < numbers.Length; z++)
                    {
                        if (numbers[x] + numbers[y] + numbers[z] == 2020)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Match found!");
                Console.WriteLine($"First index: [{x}]; Value: {numbers[x]}");
                Console.WriteLine($"Second index: [{y}]; Value: {numbers[y]}");
                Console.WriteLine($"Third index: [{z}]; Value: {numbers[z]}");
                Console.WriteLine($"Added together: {numbers[x]} + {numbers[y]} + {numbers[z]} = {numbers[x] + numbers[y] + numbers[z]}");
                Console.WriteLine($"Multiplied together: {numbers[x]} * {numbers[y]} * {numbers[z]} = {numbers[x] * numbers[y] * numbers[z]}");
            }
            else
            {
                Console.WriteLine("Match not found.");
            }
        }
    }
}