using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string solution(string letter)
    {
        // static readonly 로 미리 정의하면 매번 새로 안 만들어도 됨
        var morse = new Dictionary<string, char>()
        {
            [".-"]='a', ["-..."]='b', ["-.-."]='c', ["-.."]='d', ["."]='e',
            ["..-."]='f', ["--."]='g', ["...."]='h', [".."]='i', [".---"]='j',
            ["-.-"]='k', [".-.."]='l', ["--"]='m', ["-."]='n', ["---"]='o',
            [".--."]='p', ["--.-"]='q', [".-."]='r', ["..."]='s', ["-"]='t',
            ["..-"]='u', ["...-"]='v', [".--"]='w', ["-..-"]='x', ["-.--"]='y', ["--.."]='z'
        };

        // StringBuilder 사용 → 문자열 연결 비용 감소
        var sb = new StringBuilder();

        // Split() 결과를 한 번에 순회
        foreach (var code in letter.Split(' '))
            sb.Append(morse[code]);

        return sb.ToString();
    }
}
