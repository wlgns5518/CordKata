using System;

public class Solution
{
    public int solution(string my_string)
    {
        string[] tokens = my_string.Split(' ');
        int result = int.Parse(tokens[0]);

        for (int i = 1; i < tokens.Length; i += 2)
        {
            string op = tokens[i];
            int num = int.Parse(tokens[i + 1]);

            if (op == "+")
                result += num;
            else if (op == "-")
                result -= num;
        }

        return result;
    }
}