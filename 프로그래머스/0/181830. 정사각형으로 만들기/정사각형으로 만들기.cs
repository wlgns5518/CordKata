using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int row = arr.GetLength(0);
        int col = arr.GetLength(1);
        int n = Math.Max(row,col);
            
        int[,] answer = new int[n,n];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(i<row && j<col)
                    answer[i,j] = arr[i,j];
                else
                    answer[i,j] = 0;
            }
        }
        return answer;
    }
}