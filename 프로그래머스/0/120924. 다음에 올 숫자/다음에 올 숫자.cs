using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        if(common[2]-common[1] == common[1] - common[0])
        {
            int addNum = common[1] - common[0];
            answer = common[common.Length-1] + addNum;
        }
        else
        {
            int mulNum = common[1]/common[0];
            answer = common[common.Length-1] * mulNum;
        }
        return answer;
    }
}