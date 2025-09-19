using System;

public class Solution {
    public string[] solution(string myStr)
    {
        // 'a', 'b', 'c'를 구분자로 문자열 분리, 빈 문자열 제거
        string[] parts = myStr.Split(new char[] { 'a', 'b', 'c' }, StringSplitOptions.RemoveEmptyEntries);

        // 결과가 없으면 "EMPTY" 반환
        if (parts.Length == 0)
            return new string[] { "EMPTY" };

        return parts;
    }
}