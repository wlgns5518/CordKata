using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        var result = s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
string consoleResult = new string(result.ToArray());
Console.WriteLine(consoleResult);

    }
}