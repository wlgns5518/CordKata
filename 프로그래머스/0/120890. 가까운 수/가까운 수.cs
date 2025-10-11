using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int minNum = int.MaxValue;
        Array.Sort(array);
        for(int i=array.Length-1;i>=0;i--)
        {
            if(Math.Abs(n-array[i])<=minNum)
            {
                minNum = Math.Abs(n-array[i]);
                answer = array[i];
            }
        }
        return answer;
    }
}