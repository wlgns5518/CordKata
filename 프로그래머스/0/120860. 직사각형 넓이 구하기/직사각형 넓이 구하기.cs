using System;

public class Solution {
    public int solution(int[,] dots)
{
    int answer = 0;
    int width = 0;
    int height = 0;
    for(int i=0;i<dots.GetLength(0);i++)
    {
        if (dots[0, 0] != dots[i, 0])
            width = dots[i, 0] - dots[0, 0];
        if (dots[0,1] != dots[i, 1])
            height = dots[i, 1] - dots[0, 1];
    }
    answer = width * height;
    if (answer < 0)
        answer = answer * -1;
    return answer;
}
}