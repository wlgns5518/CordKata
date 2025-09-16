using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> result = new List<int>();
        
        for(int i = l; i <= r; i++) {
            int num = i;
            bool valid = true;
            
            if(num == 0) valid = true; // 0도 포함 가능
            
            while(num > 0) {
                int digit = num % 10;
                if(digit != 0 && digit != 5) {
                    valid = false;
                    break;
                }
                num /= 10;
            }
            
            if(valid) result.Add(i);
        }
        
        if(result.Count == 0) return new int[]{-1};
        return result.ToArray();
    }
}