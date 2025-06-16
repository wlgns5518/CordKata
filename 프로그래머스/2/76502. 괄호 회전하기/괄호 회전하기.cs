using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        var stack = new Stack<char>();
        var sb = new StringBuilder(s);

        for (int i = 0; i < s.Length; i++)
        {
            if (Check(sb.ToString(), stack))
                answer++;

            // 문자열 회전: 맨 앞 문자를 맨 뒤로 이동
            char first = sb[0];
            sb.Remove(0, 1);
            sb.Append(first);
        }

        return answer;
    }

    private bool Check(string s, Stack<char> stack)
    {
        stack.Clear();
        foreach (var item in s)
        {
            if (item == '[' || item == '(' || item == '{')
                stack.Push(item);
            else if (stack.Count == 0)
                return false;
            else if (stack.Peek() == '[' && item != ']')
                return false;
            else if (stack.Peek() == '(' && item != ')')
                return false;
            else if (stack.Peek() == '{' && item != '}')
                return false;
            else
                stack.Pop();
        }
        return stack.Count == 0;
    }
}