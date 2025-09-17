using System;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int a = slicer[0];
        int b= slicer[1];
        int c= slicer[2];
        int[] answer = null;
        if(n==1)
        {
            answer = new int[b+1];
            for(int i=0;i<answer.Length;i++)
            {
                answer[i] = num_list[i];
            }
        }
        else if(n==2)
        {
            answer = new int[num_list.Length-a];
            for(int i=0;i<answer.Length;i++)
            {
                answer[i] = num_list[a+i];
            }
        }
        else if(n == 3)
        {
            answer = new int[b-a+1];
            for(int i=0;i<answer.Length;i++)
            {
                answer[i] = num_list[a+i];
            }
        }
        else
        {
            answer = new int[(b-a)/c+1];
            for(int i=0;i<answer.Length;i++)
            {
                answer[i] = num_list[a+i*c];
            }
        }
        return answer;
    }
}