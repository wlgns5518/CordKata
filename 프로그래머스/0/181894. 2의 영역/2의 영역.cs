using System;

public class Solution {
    public int[] solution(int[] arr)
{
    int firstIndex = Array.IndexOf(arr, 2);
    if (firstIndex == -1) // 값이 없으면 바로 0 반환
        return new int[] { -1 };

    int lastIndex = Array.LastIndexOf(arr, 2);
    int[] answer = new int[lastIndex - firstIndex + 1];

    for (int i = firstIndex; i <= lastIndex; i++)
    {
        answer[i - firstIndex] = arr[i]; // count 대신 i - firstIndex 사용
    }

    return answer;
}
}