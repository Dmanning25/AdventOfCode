using AdventOfCode2020.Puzzles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
    public class Program
    {
        private static IEnumerable<string> GetData(string fileName)
        {
            return File.ReadLines($"Inputs\\{fileName}").ToList();
        }

        public static void Main(string[] args)
        {
            string input;
            IEnumerable<string> rawData;

            do
            {
                Console.Write("Enter a day to display solutions for (or Enter to quit): ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        rawData = GetData("Day1.txt");
                        int[] numbers = rawData.Select(x => int.Parse(x)).ToArray();
                        Console.WriteLine("Begin Part 1...");
                        Day1.ExecutePart1(numbers);
                        Console.WriteLine("Begin Part 2...");
                        Day1.ExecutePart2(numbers);
                        break;
                    case "2":
                        rawData = GetData("Day2.txt");
                        Console.WriteLine("Begin Part 1...");
                        Day2.ExecutePart1(rawData);
                        Console.WriteLine("Begin Part 2...");
                        Day2.ExecutePart2(rawData);
                        break;
                    case "":
                        Console.WriteLine("Goodbye.");
                        break;
                    default:
                        Console.WriteLine("Invalid entry.");
                        break;
                }
            } while (input != "");
        }
    }
}
