using System;
using System.Linq;

public class Solution {
    public int solution(string myString, string pat) {
        // 모두 소문자로 변환
        string lowerMyString = myString.ToLower();
        string lowerPat = pat.ToLower();

        return lowerMyString.Contains(lowerPat) ? 1 : 0;
    }
}