using System;

public class Solution {
    public int solution(int n) {
        int count = 0;
        int num = 0;

        while (count < n)
        {
            num++;
            // 3의 배수거나 숫자 3이 포함되어 있으면 제외
            if (num % 3 == 0 || num.ToString().Contains("3"))
                continue;

            count++;
        }

        return num;
    }
}
