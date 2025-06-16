using System;
using System.Collections.Generic;


    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                if (IsValid(s))
                    answer++;

                // 문자열 회전
                s = s.Substring(1) + s[0];
            }
            return answer;
        }

        private bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;
                    char open = stack.Pop();
                    if (!IsPair(open, c))
                        return false;
                }
            }
            return stack.Count == 0;
        }

        private bool IsPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }