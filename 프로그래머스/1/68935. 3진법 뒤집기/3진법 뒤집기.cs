using System;
using System.Collections.Generic;

public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            int remain = 0;
            List<int> base3 = new List<int>();
            int share=1;
            while (share>0)
            {
                share  =  n / (int)Math.Pow(3, remain);
                remain++;
            }
            for(int i = remain-2;i>=0;i--)
            {
                share = n / (int)Math.Pow(3, i);
                n %= (int)Math.Pow(3, i);
                base3.Add(share);
            }
            for (int i = 0; i < base3.Count; i++)
            {
                answer += base3[i] * (int)Math.Pow(3, i);
            }

            return answer;
        }
    }