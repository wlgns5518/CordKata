using System;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        int[] answer = new int[start_num-end_num+1];
        for(int i=0;i<answer.Length;i++)
        {
            answer[i] = start_num-i;
        }
        return answer;
    }
}