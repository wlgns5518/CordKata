using System;
using System.Linq;

public class Solution {
    public int solution(string[] strArr) {
        int[] count = new int[31];
        int answer = 0;

        for(int i = 0;i < strArr.Length;i++)
        {
            count[strArr[i].Length]++;
        }       

        return count.Max();
    }
}