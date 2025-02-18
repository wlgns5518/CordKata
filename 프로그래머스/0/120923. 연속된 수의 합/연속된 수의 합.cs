using System;
using System.Linq;

public class Solution {
    public int[] solution(int num, int total) {
        int start = (2 * total / num - num + 1) / 2;
        return Enumerable.Range(start, num).ToArray();
    }
}