using System;
using System.Collections.Generic;

public class Solution
{
    public List<int> solution(string today, string[] terms, string[] privacies)
    {
        Dictionary<string, int> termDict = new Dictionary<string, int>();
        foreach (var term in terms)
        {
            var split = term.Split(' ');
            termDict[split[0]] = int.Parse(split[1]);
        }

        int todayDays = ConvertToDays(today);
        List<int> result = new List<int>();

        for (int i = 0; i < privacies.Length; i++)
        {
            var split = privacies[i].Split(' ');
            string date = split[0];
            string type = split[1];

            int collectedDays = ConvertToDays(date);
            int expireAfter = termDict[type] * 28;
            int expireDate = collectedDays + expireAfter - 1;

            if (expireDate < todayDays)
            {
                result.Add(i + 1); // 개인정보 번호는 1부터 시작
            }
        }

        return result;
    }

    private int ConvertToDays(string date)
    {
        var parts = date.Split('.');
        int year = int.Parse(parts[0]);
        int month = int.Parse(parts[1]);
        int day = int.Parse(parts[2]);

        return (year * 12 * 28) + (month * 28) + day;
    }
}
