# Module 5 Lecture 2 #

```c#
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
            
```
