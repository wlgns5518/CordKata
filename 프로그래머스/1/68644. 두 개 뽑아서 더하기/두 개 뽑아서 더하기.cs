using System.Collections.Generic;
using System.Linq;
using System;

public class Solution
    {
        public int[] solution(int[] numbers)
        {
            HashSet<int> result = new HashSet<int>();
            int n = numbers.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    result.Add(numbers[i] + numbers[j]);
                }
            }
            int[] sortedResult = result.ToArray();
            Array.Sort(sortedResult);  // 정렬
            return sortedResult;
        }
    }