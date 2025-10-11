using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        int maxNum = 0;
        int index = 0;
        for(int i=0;i<array.Length;i++)
        {
            if(array[i]>maxNum)
            {
                maxNum = array[i];
                index = i;
            }
        }
        answer[0] = maxNum;
        answer[1] = index;
        return answer;
    }
}