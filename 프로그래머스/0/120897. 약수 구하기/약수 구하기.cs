using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int n)
    {
        List<int> divisors = new List<int>();
        
        for (int i = 1; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                divisors.Add(i);
                if (i != n / i)
                    divisors.Add(n / i);
            }
        }
        
        divisors.Sort();
        return divisors.ToArray();
    }
}
