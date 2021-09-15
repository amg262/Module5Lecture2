# Module 5 Lecture 2 #

Class on 9/15/2021 that was 2nd half of Arrays & Collections lecture

### Sorting array and getting sum, min, max, average
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

### List ### 
```c#
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
```


### Dictionary ### 
```c#
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
```