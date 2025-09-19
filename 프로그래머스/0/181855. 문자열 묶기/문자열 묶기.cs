using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] strArr) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int maxCount = 0;

        foreach (var str in strArr) {
            int len = str.Length;
            if (!dict.ContainsKey(len)) dict[len] = 0;
            dict[len]++;
            if (dict[len] > maxCount) maxCount = dict[len];
        }

        return maxCount;
    }
}