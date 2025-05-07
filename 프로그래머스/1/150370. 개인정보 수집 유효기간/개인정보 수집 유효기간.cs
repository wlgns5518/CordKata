using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string today, string[] terms, string[] privacies)
{
    List<int> answerList = new List<int>();
    DateTime todayDate;
    DateTime privaciesDate;
    DateTime.TryParse(today, out todayDate);
    for(int i=0;i<terms.Length;i++)
    {
        string[] termType = terms[i].Split(' ');
        for(int j=0;j<privacies.Length;j++)
        {
            string[] privaciesType = privacies[j].Split(' ');
            if (termType[0] == privaciesType[1])
            {
                DateTime.TryParse(privaciesType[0], out privaciesDate);
                int addMonth;
                int.TryParse(termType[1], out addMonth);
                privaciesDate = privaciesDate.AddMonths(addMonth);
                if (privaciesDate <= todayDate)
                    answerList.Add(j+1);
            }
        }
    }
    answerList.Sort();
    int[] answer = answerList.ToArray();
    return answer;
}
}
