using System;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score)
{
    int answer = 0;
    Array.Sort(score); // 오름차순 정렬
    Array.Reverse(score); // 내림차순으로 변경

    for (int i = 0; i + m <= score.Length; i += m)
    {
        // m개씩 그룹화하여 처리
        int[] group = score.Skip(i).Take(m).ToArray();
        int minInGroup = group[m - 1]; // 그룹에서 가장 작은 값
        answer += minInGroup * m; // 그룹의 점수 계산
    }

    return answer;
}
}