using System;

public class Solution {
        public bool solution(string s)
    {
        int count = 0;
        char[] chars = s.ToCharArray();
        foreach (char c in chars)
        {
            if (c == '(')
                count++;
            else if (c == ')')
            {
                count--;
                if (count < 0)
                    return false;
            }
        }
        return count==0;
    }
}