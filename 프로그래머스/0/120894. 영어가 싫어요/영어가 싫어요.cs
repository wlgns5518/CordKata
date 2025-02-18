using System;

public class Solution {
    public long solution(string numbers)
{
    long answer=0;
    if (numbers.Contains("one"))
        numbers=numbers.Replace("one", "1");
    if (numbers.Contains("two"))
        numbers=numbers.Replace("two", "2");
    if (numbers.Contains("three"))
        numbers = numbers.Replace("three", "3");
    if (numbers.Contains("four"))
        numbers=numbers.Replace("four", "4");
    if (numbers.Contains("five"))
        numbers = numbers.Replace("five", "5");
    if (numbers.Contains("six"))
        numbers = numbers.Replace("six", "6");
    if (numbers.Contains("seven"))
        numbers = numbers.Replace("seven", "7");
    if (numbers.Contains("eight"))
        numbers = numbers.Replace("eight", "8");
    if (numbers.Contains("nine"))
        numbers = numbers.Replace("nine", "9");
    if (numbers.Contains("zero"))
        numbers = numbers.Replace("zero", "0");
    long.TryParse(numbers,out answer);
    return answer;
}
}