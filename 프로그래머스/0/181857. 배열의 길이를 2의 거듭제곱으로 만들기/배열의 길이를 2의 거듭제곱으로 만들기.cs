using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int n = arr.Length;
        int targetLength = 1;

        // n 이상인 가장 작은 2의 거듭제곱 찾기
        while (targetLength < n) {
            targetLength *= 2;
        }

        // targetLength - n 만큼 0 추가
        int[] result = new int[targetLength];
        Array.Copy(arr, result, n);

        return result;
    }
}