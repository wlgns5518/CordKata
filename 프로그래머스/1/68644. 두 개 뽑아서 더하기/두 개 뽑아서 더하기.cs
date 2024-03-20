using System.Collections.Generic;
using System.Linq;
using System;

public class Solution
    {
        public int[] solution(int[] numbers)
        {
            List<int> result = new List<int>();
            int n = numbers.Length;
            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    int sum = numbers[i] + numbers[j];
                    if (!result.Contains(sum)) {
                        result.Add(sum);
                    }
                }
            }
            result.Sort(); // 오름차순으로 정렬
            return result.ToArray();
        }
    }