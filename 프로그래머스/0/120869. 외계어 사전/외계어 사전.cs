using System;

public class Solution {
    public int solution(string[] spell, string[] dic)
{
    int answer = 2;
    for (int i = 0; i < dic.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < spell.Length; j++)
        {
            if (dic[i].Contains(spell[j]))
            {
                count++;
            }
        }
        if (count == spell.Length)
            answer = 1;
    }
    return answer;
}
}