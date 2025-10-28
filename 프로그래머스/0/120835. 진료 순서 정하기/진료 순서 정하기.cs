using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] emergency)
    {
        // emergency를 내림차순 정렬
        int[] sorted = emergency.OrderByDescending(x => x).ToArray();

        // 각 원소의 진료 순서를 담을 배열
        int[] answer = new int[emergency.Length];

        for (int i = 0; i < emergency.Length; i++)
        {
            // emergency[i]가 sorted 배열에서 몇 번째인지 찾아서 순서 지정
            answer[i] = Array.IndexOf(sorted, emergency[i]) + 1;
        }

        return answer;
    }
}
