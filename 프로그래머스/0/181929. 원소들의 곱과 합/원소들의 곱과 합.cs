using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;

        answer = num_list.Aggregate(1, (x, y) => x * y) < Math.Pow(num_list.Sum(), 2) ? 1 : 0;

        return answer;
    }
}