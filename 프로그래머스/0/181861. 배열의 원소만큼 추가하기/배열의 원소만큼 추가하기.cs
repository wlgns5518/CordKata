using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        // 결과 배열 길이는 arr 원소 합
        int[] answer = new int[arr.Sum()];
        int idx = 0; // 결과 배열 현재 위치

        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr[i]; j++)
            {
                answer[idx++] = arr[i]; // idx를 하나씩 증가
            }
        }

        return answer;
    }
}