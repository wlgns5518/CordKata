using System;

public class Solution {
   public int solution(string s)
{
    int answer = 0;
    int num = 0;
    string[] sArray = s.Split();
    for (int i = 0; i < sArray.Length; i++)
    {
        if (sArray[i] == "Z")
            answer -= num;
        else
        {
            int.TryParse(sArray[i], out num );
            answer += num;
        }
    }
    return answer;
}
}