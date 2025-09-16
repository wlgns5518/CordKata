using System;

public class Solution {
     public int[] solution(int[] num_list) {
        int n = num_list.Length;
        int last = num_list[n - 1];
        int prev = num_list[n - 2];
        
        // 크기 1 늘린 새 배열 생성
        int[] result = new int[n + 1];
        Array.Copy(num_list, result, n);

        // 조건에 맞는 값 추가
        if (last > prev)
            result[n] = last - prev;
        else
            result[n] = last * 2;

        return result;
    }
}