using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int oddNum= 0;
        int evenNum = 0;
        for(int i=0;i<num_list.Length;i++)
        {
            if((i+1)%2==0)
                oddNum +=num_list[i];
            else
                evenNum += num_list[i];
        }
        if(oddNum > evenNum)
            return oddNum;
        else
            return evenNum;
        return answer;
    }
}