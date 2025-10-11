using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        int temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > temp)
            {
                temp = array[i];
                answer[0] = temp;
                answer[1] = i;            
            }         
        }

        return answer;
    }
}