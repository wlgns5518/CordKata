using System;
using System.Linq;
public class Solution {
    public int solution(int[] num_list) {
        int answer = num_list.Length <= 10 ? num_list.Aggregate((a, b) => a * b) : num_list.Sum();
        return answer;
    }
}