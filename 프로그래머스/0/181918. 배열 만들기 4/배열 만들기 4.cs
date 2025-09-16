using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr)
{
    var stk = new List<int>();
    int i = 0;
    while (i < arr.Length)
    {
        if (stk.Count == 0)
        {
            stk.Add(arr[i]);
            i++;
        }
        else
        {
            if (stk.Last() < arr[i])
            {
                stk.Add(arr[i]);
                i++;
            }
            else
            {
                stk.Remove(stk.Last());
            }
        }
            

    }
    return stk.ToArray();
}
}