using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        foreach(int i in array)
        {
            int temp = i;
            while(temp>0)
            {
                if(temp%10==7)
                    answer++;
                temp/=10;
            }
        }
        return answer;
    }
}