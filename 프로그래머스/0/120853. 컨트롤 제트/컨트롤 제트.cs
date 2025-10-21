using System;
using System.Collections.Generic;

public class Solution {
public int solution(string s)
{
    int answer = 0;
    int num = 0;
    int start = 0;

    Stack<int> stack = new Stack<int>();

    for (int i = 0; i <= s.Length; i++)
    {
        if (i == s.Length || s[i] == ' ')
        {
            if (start < i)
            {
                string token = s.Substring(start, i - start);
                if (token == "Z")
                {
                    if (stack.Count > 0)
                    {
                        answer -= stack.Pop();
                    }
                }
                else
                {
                    num = int.Parse(token);
                    stack.Push(num);
                    answer += num;
                }
            }
            start = i + 1;
        }
    }

    return answer;
}
}