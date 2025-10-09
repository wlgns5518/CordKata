using System;

public class Solution {
    public int solution(string str1, string str2) 
    {
        if (str1.Length < str2.Length)
            return 2;
        else if (str1.Length == str2.Length)
        {
            if (str1 == str2)
                return 1;
            else
                return 2;
        }

        for (int i = 0; i <= str1.Length - str2.Length; i++)
        {
            int count = 0;   
            for (int j = 0; j < str2.Length; j++)
            {
                if (str1[i + j] == str2[j])
                {
                    count++;
                    if (count == str2.Length)
                        return 1;
                }
                else
                    break;   
            }
        }
        return 2;
    }
}