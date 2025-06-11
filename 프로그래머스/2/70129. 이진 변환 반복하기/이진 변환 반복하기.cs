using System;
using System.Linq;
using System.Text;

public class Solution {
    public int[] solution(string s)
{
    int[] answer = new int[2];
    StringBuilder sb = new StringBuilder();
    bool isTrue = true;
    int zeroCount = 0;
    int convertCount = 0;
    while(isTrue)
    {
        sb = new StringBuilder();
        foreach (char s2 in s)
        {
            if (s2 == '1')
                sb.Append(s2);
            else
                zeroCount++;
        }
        convertCount++;
        if (sb.Length == 1)
        {
            isTrue = false;
        }
        else
        {
            s = Convert.ToString(sb.Length, 2);
            
        }

    }
    answer[1] = zeroCount;
    answer[0] = convertCount;
    return answer;
}
}