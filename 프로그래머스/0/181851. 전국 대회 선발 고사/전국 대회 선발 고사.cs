using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] rank, bool[] attendance)
{
    int answer = 0;
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (int i = 0; i < rank.Length; i++)
    {
        if (attendance[i])
            dic.Add(rank[i], i);
    }
    List<int> list = dic.Keys.ToList();
    list.Sort();
    answer = dic[list[0]] * 10000 + dic[list[1]] * 100 + dic[list[2]];
    return answer;
}
}