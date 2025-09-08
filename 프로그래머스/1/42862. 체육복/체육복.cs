using System;

public class Solution {
     public int solution(int n, int[] lost, int[] reserve)
{
    // 인덱스 가드용으로 n+2 사용
    bool[] hasReserve = new bool[n + 2];
    bool[] isLost = new bool[n + 2];

    for (int i = 0; i < reserve.Length; i++)
        hasReserve[reserve[i]] = true;
    for (int i = 0; i < lost.Length; i++)
        isLost[lost[i]] = true;

    // 1) 겹치는 학생 선처리: 자기 걸로 해결하고 빌려줄 여분도 없앰
    for (int i = 1; i <= n; i++)
    {
        if (isLost[i] && hasReserve[i])
        {
            isLost[i] = false;
            hasReserve[i] = false;
        }
    }

    // 2) 대여: 왼쪽 -> 오른쪽 우선
    int answer = n;
    for (int i = 1; i <= n; i++)
    {
        if (isLost[i])
        {
            if (hasReserve[i - 1])
            {
                hasReserve[i - 1] = false;
            }
            else if (hasReserve[i + 1])
            {
                hasReserve[i + 1] = false;
            }
            else
            {
                answer--;
            }
        }
    }

    return answer;
}
}