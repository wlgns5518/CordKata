using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] players, int m, int k)
    {
        int answer = 0;
        var serverCom = new List<int>();
        for (int i = 0; i < players.Length; i++)
        {
            int ns = serverCom.Count;
            int np = players[i];
            int nn = np / m;

            if (nn>ns)
            {
                int n = nn - ns;
                for (int j = 0; j < n; j++)
                {
                    serverCom.Add(0);
                    answer++;
                }
            }
            for (int j = 0; j < serverCom.Count; j++)
            {
                serverCom[j]++;
            }
            serverCom.RemoveAll(index => index>=k);
        }
        return answer;
    }

}