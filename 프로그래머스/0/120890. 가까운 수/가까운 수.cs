using System;

public class Solution
{
    public int solution(int[] array, int n)
    {
        Array.Sort(array); // 오름차순 정렬
        int answer = array[0];
        int minDiff = Math.Abs(n - array[0]);

        for (int i = 1; i < array.Length; i++)
        {
            int diff = Math.Abs(n - array[i]);
            if (diff < minDiff) // 더 작은 차이 발견
            {
                minDiff = diff;
                answer = array[i];
            }
            // diff == minDiff인 경우는 이미 정렬되어 있으므로 answer 유지 → 자동으로 작은 수 선택
        }

        return answer;
    }
}