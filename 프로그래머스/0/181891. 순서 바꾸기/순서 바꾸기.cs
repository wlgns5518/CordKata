using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        int count = 0;
        for(int i=n;i<answer.Length;i++)
        {
            answer[count++] = num_list[i];
        }
        for(int i=0;i<n;i++)
        {
            answer[count++] = num_list[i];
        }
        return answer;
    }
}