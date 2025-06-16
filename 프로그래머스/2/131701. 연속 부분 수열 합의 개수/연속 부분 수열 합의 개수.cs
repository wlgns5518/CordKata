using System;
using System.Collections.Generic;


public class Solution {
    public int solution(int[] elements)
{
    int n = elements.Length;
    HashSet<int> sums = new HashSet<int>();

    // 배열을 두 번 이어붙여 원형 처리
    int[] doubleElements = new int[n * 2];
    Array.Copy(elements, 0, doubleElements, 0, n);
    Array.Copy(elements, 0, doubleElements, n, n);

    // 부분 수열의 길이 1부터 n까지
    for (int len = 1; len <= n; len++)
    {
        int sum = 0;
        // 첫 윈도우 합 구하기
        for (int i = 0; i < len; i++)
            sum += doubleElements[i];
        sums.Add(sum);

        // 슬라이딩 윈도우
        for (int start = 1; start < n; start++)
        {
            sum = sum - doubleElements[start - 1] + doubleElements[start + len - 1];
            sums.Add(sum);
        }
    }

    return sums.Count;
}
}