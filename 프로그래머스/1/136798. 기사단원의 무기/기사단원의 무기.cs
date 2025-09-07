using System;

public class Solution {
    public int solution(int number, int limit, int power)
{
    int answer = 0;

    for (int i = 1; i <= number; i++)
    {
        int cnt = 0;

        for (int j = 1; j*j <= i; j++)
        {
            if (i % j == 0)
            {
                // j가 제곱근이면 한 번만 더하고, 아니면 짝으로 2개 추가
                cnt += (j * j == i) ? 1 : 2;
                // limit를 초과하면 더 계산할 필요 없음
                if (cnt > limit) break;
            }
        }

        answer += (cnt > limit) ? power : cnt;
    }

    return answer;
}
}