using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        for(int i=0;i<my_string.Length;i++)
        {
            if(my_string.Substring(0,i) == is_prefix)
                return 1;
        }
        return answer;
    }
}