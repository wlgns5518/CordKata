using System;

public class Solution {
    public int solution(int n)
{
    int answer = 0;

    for (int i = 0; i < n; i++)
    {
        answer++;

        // 3의 배수이거나 숫자 3이 포함되어 있으면 계속 건너뜀
        while (answer % 3 == 0 || HasThree(answer))
        {
            answer++;
        }
    }

    return answer;
}

// 숫자 안에 3이 포함되어 있는지 검사하는 함수
bool HasThree(int num)
{
    while (num > 0)
    {
        if (num % 10 == 3) // 끝자리 숫자가 3이면 true
            return true;

        num /= 10; // 다음 자리로 이동
    }

    return false;
}


}
