using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string s)
    {
        Dictionary<char, int> count = new Dictionary<char, int>();

        // 1️⃣ 등장 횟수 세기
        foreach (char c in s)
        {
            if (count.ContainsKey(c))
                count[c]++;
            else
                count[c] = 1;
        }

        // 2️⃣ 한 번만 등장한 문자만 리스트에 추가
        List<char> singleChars = new List<char>();
        foreach (var kvp in count)
        {
            if (kvp.Value == 1)
                singleChars.Add(kvp.Key);
        }

        // 3️⃣ 사전 순으로 정렬
        singleChars.Sort();

        // 4️⃣ 문자열로 변환
        return new string(singleChars.ToArray());
    }
}
