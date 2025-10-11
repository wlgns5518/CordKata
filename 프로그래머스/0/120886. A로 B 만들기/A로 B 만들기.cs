using System;

public class Solution {
    public int solution(string before, string after) {
        int[] count = new int[26]; // a~z

        // before 문자열 문자 개수 증가
        foreach (char c in before) {
            count[c - 'a']++;
        }

        // after 문자열 문자 개수 감소
        foreach (char c in after) {
            count[c - 'a']--;
        }

        // 하나라도 0이 아니면 만들 수 없음
        foreach (int c in count) {
            if (c != 0) return 0;
        }

        return 1;
    }
}
