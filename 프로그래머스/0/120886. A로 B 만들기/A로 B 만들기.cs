using System;

public class Solution {
    public int solution(string before, string after) {
        // 문자열을 문자 배열로 변환
        char[] beforeArr = before.ToCharArray();
        char[] afterArr = after.ToCharArray();

        // 문자 배열 정렬
        Array.Sort(beforeArr);
        Array.Sort(afterArr);

        // 정렬 후 문자열로 변환
        string sortedBefore = new string(beforeArr);
        string sortedAfter = new string(afterArr);

        // 비교 후 결과 반환
        return sortedBefore == sortedAfter ? 1 : 0;
    }
}