using System;

public class Solution {
   public int solution(int[] array)
{
    Array.Sort(array);
    int mode = 0;
    int cnt = 0;
    int maxcnt = 0;
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[n] == array[i])
        {
            cnt++;
            if (maxcnt < cnt)
            {
                maxcnt = cnt;
                mode = array[n];
            }
            else if (maxcnt == cnt)
            {
                mode = -1;
            }
        }
        else
        {
            n = i;
            i--;
            cnt = 0;
        }
    }

    return mode;
}
}