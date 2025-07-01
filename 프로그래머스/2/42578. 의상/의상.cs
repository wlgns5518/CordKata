using System;
using System.Linq;

public class Solution {
    public int solution(string[,] clothes) {
        return Enumerable.Range(0, clothes.GetLength(0)).Select(i => clothes[i,1]).GroupBy(p => p).Select(g => g.Count() + 1).Aggregate(1, (p, q) => p * q) - 1;
    }
}