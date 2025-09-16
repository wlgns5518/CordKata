using System;

public class Solution {
    public int solution(int[] num_list) {
        int numSum = 0;
        int numMul = 1;
        for(int i=0;i<num_list.Length;i++)
        {
            numSum += num_list[i];
            numMul *= num_list[i];
        }
        return numSum*numSum > numMul? 1:0;
    }
}