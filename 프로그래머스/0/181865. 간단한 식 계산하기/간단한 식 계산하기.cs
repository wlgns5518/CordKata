using System;

public class Solution {
    public int solution(string binomial)
    {
        // 문자열을 공백 기준으로 나누기
        string[] parts = binomial.Split(' ');

        int a = int.Parse(parts[0]);
        string op = parts[1];
        int b = int.Parse(parts[2]);

        // 연산자에 따라 계산
        if (op == "+")
            return a + b;
        else if (op == "-")
            return a - b;
        else if (op == "*")
            return a * b;
        else
            throw new ArgumentException("지원되지 않는 연산자입니다.");
    }
}