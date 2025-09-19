using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string myString)
    {
        List<string> parts = new List<string>();
        int start = 0;
        
        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'x')
            {
                if (i > start) // 빈 문자열 제거
                    parts.Add(myString.Substring(start, i - start));
                start = i + 1;
            }
        }
        if (start < myString.Length)
            parts.Add(myString.Substring(start));

        parts.Sort(StringComparer.Ordinal); // 빠른 정렬
        return parts.ToArray();
    }
}
