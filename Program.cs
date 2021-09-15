using System;
using System.Linq;
using System.Threading.Channels;

namespace Module5Lecture2
{
    class Program
    {
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
            Console.WriteLine($"Average: {intrusions.Sum() / (double)intrusions.Length}");
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


        static void Main(string[] args)
        {
            IntrusionReport();
        }
    }
}