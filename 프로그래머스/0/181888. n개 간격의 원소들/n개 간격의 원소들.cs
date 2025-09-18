using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[(num_list.Length+n-1)/n];
        for(int i =0;i<answer.Length;i++) answer[i]=num_list[i*n];
        return answer;
    }
}