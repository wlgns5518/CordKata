using System;

public class Solution {
    public int solution(string str1, string str2) {
        return str2.IndexOf(str1) >= 0 ? 1 : 0;
    }
}