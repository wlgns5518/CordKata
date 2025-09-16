using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int qCount = queries.GetLength(0);
        for (int q = 0; q < qCount; q++) {
            int i = queries[q, 0];
            int j = queries[q, 1];
            
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        return arr;
    }
}