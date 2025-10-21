using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int num = 0;
        for(int i=0;i<my_string.Length;i++)
        {
            if(int.TryParse(my_string[i].ToString(),out num))
                answer += num;
        }
        return answer;
    }
}