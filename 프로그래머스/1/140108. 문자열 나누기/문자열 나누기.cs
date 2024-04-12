using System;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        char x = ' ';
        while(s.Length > 0)
        {
            int sameChar = 0;
            int notSameChar = 0;
            x = s[0];
            for(int i=0;i<s.Length; i++)
            {
                if (x == s[i])
                    sameChar++;
                else
                    notSameChar++;
                if (sameChar == notSameChar)
                {
                    s = s.Substring(i+1);
                    answer++;
                    break;
                }
                if(i == s.Length - 1)
                {
                    s = s.Substring(i + 1);
                    answer++;
                }
            }
        }
        return answer;
    }
}