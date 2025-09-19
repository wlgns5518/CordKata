using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list)
{
    Array.Sort(num_list);
    int[] answer = num_list.Take(5).ToArray();
    return answer;
}
}