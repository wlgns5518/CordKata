using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> result = new List<int>();
        
        for(int i = l; i <= r; i++) {
            string s = i.ToString();
            bool valid = true;
            
            foreach(char c in s) {
                if(c != '0' && c != '5') {
                    valid = false;
                    break;
                }
            }
            
            if(valid) result.Add(i);
        }
        
        if(result.Count == 0) return new int[]{-1};
        return result.ToArray();
    }
}