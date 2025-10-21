using System;
using System.Linq;

public class Solution {
    public int solution(int[] sides)
{
    int answer = 0;
    int maxSide = sides.Max();
    int minSide = sides.Min();
    for(int i=0;i<maxSide;i++)
    {
        if(i+minSide > maxSide)
            answer++;
    }
    for(int i = maxSide;i<maxSide+minSide;i++)
    {
        if(maxSide + minSide > i)
            answer++;
    }
    return answer;
}
}