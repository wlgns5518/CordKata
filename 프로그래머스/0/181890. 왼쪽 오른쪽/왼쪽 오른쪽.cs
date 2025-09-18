using System;
using System.Linq;

public class Solution {
     public string[] solution(string[] str_list)
    {
        int lIndex = Array.IndexOf(str_list, "l");
        int rIndex = Array.IndexOf(str_list, "r");

        if (lIndex != -1 && (rIndex == -1 || lIndex < rIndex))
            return str_list.Take(lIndex).ToArray();       // "l" 먼저 또는 "r" 없음
        if (rIndex != -1)
            return str_list.Skip(rIndex + 1).ToArray();   // "r" 먼저 또는 "l" 없음

        return Array.Empty<string>();                     // 둘 다 없음
    }
}