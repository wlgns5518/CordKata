using System;

public class Solution
{
    public int[] solution(string[] wallpaper)
    {
        int[] answer = new int[4];
        int lux = int.MaxValue;
        int luy = int.MaxValue;
        int rdx = 0;
        int rdy = 0;
        for(int i = 0;i<wallpaper.Length;i++)
        {
            if (wallpaper[i].IndexOf("#") != -1)
            {
                if(lux >i)
                    lux = i;
                if(luy > wallpaper[i].IndexOf("#"))
                    luy = wallpaper[i].IndexOf("#");
                if(rdx < i+1)
                    rdx = i + 1;
                if (rdy < wallpaper[i].LastIndexOf("#")+1)
                    rdy = wallpaper[i].LastIndexOf("#")+1;
            }
        }
        answer[0] = lux;
        answer[1] = luy;
        answer[2] = rdx;
        answer[3] = rdy;
        return answer;
    }
}