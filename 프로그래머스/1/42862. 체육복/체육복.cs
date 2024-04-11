using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = n - lost.Length;
        List<int> lostList = lost.ToList();
        List<int> reserveList = reserve.ToList();
        lostList.Sort();
        reserveList.Sort();
        for (int i = reserveList.Count - 1; i >= 0; i--)
        {
            for (int j = lostList.Count - 1; j >= 0; j--)
            {
                if (reserveList[i] == lostList[j])
                {
                    answer++;
                    lostList.RemoveAt(j);
                    reserveList.RemoveAt(i);
                    break;
                }
            }
        }
        for (int i = reserveList.Count-1; i >= 0; i--)
        {
            for (int j = lostList.Count-1; j >= 0; j--)
            {
                if (reserveList[i] + 1 == lostList[j] || reserveList[i] - 1 == lostList[j])
                {
                    answer++;
                    lostList.RemoveAt(j);
                    reserveList.RemoveAt(i);
                    break;
                }
            }
        }
        return answer;
    }
}