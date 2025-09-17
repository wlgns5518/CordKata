using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int a = slicer[0];
        int b = slicer[1];
        int c = slicer[2];

        int start = 0, end = num_list.Length - 1, step = 1;

        if(n == 1) { start = 0; end = b; step = 1; }
        else if(n == 2) { start = a; end = num_list.Length - 1; step = 1; }
        else if(n == 3) { start = a; end = b; step = 1; }
        else if(n == 4) { start = a; end = b; step = c; }

        int size = ((end - start) / step) + 1;
        int[] answer = new int[size];

        for(int i = 0; i < size; i++) {
            answer[i] = num_list[start + i * step];
        }

        return answer;
    }
}