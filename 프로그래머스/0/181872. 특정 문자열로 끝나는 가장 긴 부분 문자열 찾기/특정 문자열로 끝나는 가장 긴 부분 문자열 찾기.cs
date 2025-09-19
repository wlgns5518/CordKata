using System;

public class Solution {
    public string solution(string myString, string pat) {
        int idx = myString.LastIndexOf(pat); // pat이 마지막으로 등장하는 위치
        if (idx == -1) return ""; // 없다면 빈 문자열 반환 (혹은 문제 조건에 맞게 처리)
        return myString.Substring(0, idx + pat.Length);
    }
}