using System;

public class Solution {
    public int solution(string num_str)
    {
        int answer = 0;
        int num = 0;
        for (int i = 0; i < num_str.Length; i++)
        {
            int.TryParse(num_str[i].ToString(), out num);
            answer += num;
        }
        return answer;
    }
}