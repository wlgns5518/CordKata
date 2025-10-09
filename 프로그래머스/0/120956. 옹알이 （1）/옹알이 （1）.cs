using System;

public class Solution {
    public int solution(string[] babbling) {
        string[] possible = { "aya", "ye", "woo", "ma" };
        int count = 0;

        foreach (string word in babbling)
        {
            string temp = word;
            foreach (string p in possible)
            {
                temp = temp.Replace(p, " ");
            }

            // 공백을 제거했을 때 빈 문자열이면 가능한 단어
            if (temp.Trim().Length == 0)
            {
                count++;
            }
        }

        return count;
    }
}