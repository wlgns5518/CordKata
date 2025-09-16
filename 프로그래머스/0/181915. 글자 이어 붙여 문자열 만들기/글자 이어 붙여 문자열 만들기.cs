using System;

public class Solution {
    public string solution(string my_string, int[] index_list) {
        string answer = "";
        char[] chars = new char[my_string.Length];
        for(int i=0;i<my_string.Length;i++)
        {
            chars[i] = my_string[i];
        }
        for(int i=0;i<index_list.Length;i++)
        {
            answer += chars[index_list[i]];
        }
        return answer;
    }
}