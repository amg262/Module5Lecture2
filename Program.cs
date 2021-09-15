using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Module5Lecture2
{
    class Program
    {
        static void TwoDemArray()
        {
            int[,] grades = new int[5, 2];
            string[] questions = {"Student ID>", "Student Grade>"};

            // 0 is the first row in dimension
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    Console.Write($"{col} - {questions[col]}");
                    Int32.TryParse(Console.ReadLine(), out grades[row, col]);
                }
            }

            for (int row = 0; row < grades.GetLength(0); row++)
            {
                Console.WriteLine($"{grades[row, 0]} . {grades[row, 1]}");
            }
        }

        static void IntrusionReport()
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int[] intrusions = new int[days.Length];

            for (int i = 0; i < days.Length; i++)
            {
                Console.Write($"{days[i]} intrusions>");
                Int32.TryParse(Console.ReadLine(), out intrusions[i]);
            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"{days[i]}: {intrusions[i]}");
            }

            Console.WriteLine($"Total: {intrusions.Sum()}");
            Console.WriteLine($"Average: {intrusions.Sum() / (double) intrusions.Length}");
            Console.WriteLine();

            /*
             * To get Min/max we sort both arrays first
             * Then getting first and last items where first is min and last is max
             *
             * Array.length - 1 works because the length will be 1 longer than the indexes
             * which start at 0.
             */
            Array.Sort(intrusions, days);


            Console.WriteLine($"{days[days.Length - 1]} had {intrusions[intrusions.Length - 1]}");
            Console.WriteLine($"{days[0]} had the least: {intrusions[0]}");
        }

        static void ListColors()
        {
            var colors = new List<string>()
            {
                "blue", "black", "green", "purple"
            };

            colors.Add("aquamarine");
            colors.Add("green");
            colors.Remove("green");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Which color would you like to remove?");
            Int32.TryParse(Console.ReadLine(), out int index);

            //if i have a valid # from 1 to the size of collection
            if (index > 0 && index <= colors.Count)
            {
                colors.RemoveAt(index - 1);
            }

            Console.WriteLine("New List: ");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }


        static void DictionaryTryItOut()
        {
            Console.WriteLine("Enter word:");
            string phrase = Console.ReadLine();

            var letters = new Dictionary<char, int>();

            foreach (char letter in phrase)
            {
                if (!letters.ContainsKey(letter))
                    letters.Add(letter, 1);
                else letters[letter]++;
            }

            foreach (var record in letters)
            {
                Console.WriteLine($"{record.Key} occured {record.Value} times");
            }
        }

        static void Dictionary()
        {
            var grades = new Dictionary<string, int>();
            grades["Mario"] = 100;
        }

        static void Main(string[] args)
        {
            //IntrusionReport();
            //TwoDemArray();
            //ListColors();
            DictionaryTryItOut();
        }
    }
}