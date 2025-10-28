using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] order = emergency.OrderByDescending(x => x).ToArray();
        int[] answer = emergency.Select(x => Array.IndexOf(order, x) + 1).ToArray();
        return answer;
    }
}