using System;

public class Solution {
    public int solution(int[] num_list) {
        string evenNum ="";
        string oddNum = "";
        for(int i=0;i<num_list.Length;i++)
        {
            if(num_list[i] %2 == 0)
                evenNum += $"{num_list[i]}";
            else
                oddNum += $"{num_list[i]}";
        }
        
        return int.Parse(evenNum)+int.Parse(oddNum);
    }
}